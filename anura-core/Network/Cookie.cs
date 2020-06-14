#if net
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
#nullable enable

namespace Anura.Network
{
    /// <summary>
    /// Cookie 变种类型
    /// </summary>
    public enum CookieVariant
    {
        Unknown,
        Plain,
        Rfc2109,
        Rfc2965,
        Default = Rfc2109
    }

    /// <summary>
    /// <h>Cookie</h>
    /// <para>现阶段，这个类只支持客户端 Web Cookies。 它知道如何从一个 SetCookie 语句来解码
    /// 成一个 Cookie，却不能从一个一般的 Cookie 字符串中解码</para>
    /// <para>比如说下面的这个字符串是可解码的： "Cookie: $Version=1; name=value; $Path=/foo; $Secure"</para>
    /// <para><i>( RFC 2965 )</i></para>
    /// </summary>
    [Serializable]
    public sealed class Cookie
    {
        // 这两个参数要同时更改

        internal const int MaxSupportedVersion = 1;
        internal const string MaxSupportedVersionString = "1";

        internal const string SeparatorLiteral = "; ";
        internal const string EqualsLiteral = "=";
        internal const string QuotesLiteral = "\"";
        internal const string SpecialAttributeLiteral = "$";

        internal static readonly char[] PortSplitDelimiters = new char[] { ' ', ',', '\"' };

        // 空格 （‘ ’） 在标准中应该是被识别的，但是有一部分主流浏览器并不实现它。 
        // 为了适应这个变化，许多网页会用短横线 （‘-’） 来代替它。 所以我们也支持短横线。

        internal static readonly char[] ReservedToName = new char[] { '\t', '\r', '\n', '=', ';', ',' };
        internal static readonly char[] ReservedToValue = new char[] { ';', ',' };

        // 不要重命名这些字段，尽管它们不符合 C# 的命名规则，
        // 它们的名字在二进制序列化中是有要求的。

        private string m_comment = string.Empty; 
        private Uri? m_commentUri = null; 
        private CookieVariant m_cookieVariant = CookieVariant.Plain; 
        private bool m_discard = false;
        private string m_domain = string.Empty; 
        private bool m_domain_implicit = true; 
        private DateTime m_expires = DateTime.MinValue; 
        private string m_name = string.Empty; 
        private string m_path = string.Empty;
        private bool m_path_implicit = true; 
        private string m_port = string.Empty;
        private bool m_port_implicit = true; 
        private int[]? m_port_list = null; 
        private bool m_secure = false;
        [System.Runtime.Serialization.OptionalField]
        private bool m_httpOnly = false; 
        private DateTime m_timeStamp = DateTime.Now; 
        private string m_value = string.Empty;
        private int m_version = 0; 
        private string m_domainKey = string.Empty;

        internal bool IsQuotedVersion = false;
        internal bool IsQuotedDomain = false;

        public Cookie() {
        }

        public Cookie(string name, string? value) {
            Name = name;
            Value = value;
        }

        public Cookie(string name, string? value, string? path)
            : this(name, value) {
            Path = path;
        }

        public Cookie(string name, string? value, string? path, string? domain)
            : this(name, value, path) {
            Domain = domain;
        }

        [AllowNull]
        public string Comment {
            get { return m_comment; }
            set { m_comment = value ?? string.Empty; }
        }

        public Uri? CommentUri {
            get { return m_commentUri; }
            set { m_commentUri = value; }
        }


        public bool HttpOnly {
            get { return m_httpOnly; }
            set { m_httpOnly = value; }
        }


        public bool Discard {
            get { return m_discard; }
            set { m_discard = value; }
        }

        [AllowNull]
        public string Domain {
            get { return m_domain; }
            set {
                m_domain = value ?? string.Empty;
                m_domain_implicit = false;
                m_domainKey = string.Empty; 
            }
        }

        internal bool DomainImplicit {
            get { return m_domain_implicit; }
            set { m_domain_implicit = value; }
        }

        public bool Expired {
            get { return (m_expires != DateTime.MinValue) && (m_expires.ToLocalTime() <= DateTime.Now); }
            set {
                if (value == true) 
                    m_expires = DateTime.Now;
            }
        }

        public DateTime Expires {
            get { return m_expires; }
            set {  m_expires = value; }
        }

        public string Name {
            get { return m_name; }
            set {
                if (string.IsNullOrEmpty(value) || !InternalSetName(value)) {
                    throw new CookieException(SR.Format(SR.net_cookie_attribute, "Name", value == null ? "<null>" : value));
                }
            }
        }

        internal bool InternalSetName(string? value) {
            if (string.IsNullOrEmpty(value) || value[0] == '$' || value.IndexOfAny(ReservedToName) != -1 || value[0] == ' ' || value[value.Length - 1] == ' ') {
                m_name = string.Empty;
                return false;
            }
            m_name = value;
            return true;
        }

        [AllowNull]
        public string Path {
            get { return m_path; }
            set {
                m_path = value ?? string.Empty;
                m_path_implicit = false;
            }
        }

        internal bool Plain {
            get { return Variant == CookieVariant.Plain; }
        }

        internal Cookie Clone() {
            Cookie clonedCookie = new Cookie(m_name, m_value);

            // 从原来的 Cookie 中复制所有属性

            if (!m_port_implicit) {
                clonedCookie.Port = m_port;
            }
            if (!m_path_implicit) {
                clonedCookie.Path = m_path;
            }
            clonedCookie.Domain = m_domain;

            // 如果在原来的 Cookie 中，Domain 属性是没有说明的， 我们应该保留这个属性

            clonedCookie.DomainImplicit = m_domain_implicit;
            clonedCookie.m_timeStamp = m_timeStamp;
            clonedCookie.Comment = m_comment;
            clonedCookie.CommentUri = m_commentUri;
            clonedCookie.HttpOnly = m_httpOnly;
            clonedCookie.Discard = m_discard;
            clonedCookie.Expires = m_expires;
            clonedCookie.Version = m_version;
            clonedCookie.Secure = m_secure;

            // Cookie 对象的变种在我们设置比如 port 和 version 属性的时候就已经设置了，
            // 因此我们应该在获取 Cookie 所有其他属性之后再复制 Varient 属性。

            clonedCookie.m_cookieVariant = m_cookieVariant;

            return clonedCookie;
        }

        private static bool IsDomainEqualToHost(string domain, string host) {
            // +1 in the host length is to account for the leading dot in domain
            return (host.Length + 1 == domain.Length) &&
                   (string.Compare(host, 0, domain, 1, host.Length, StringComparison.OrdinalIgnoreCase) == 0);
        }

        // 根据标准，我们必须在 Cookie 中赋予默认的属性值，但是我们在发送 Web 请求的时候又
        // 不能把这些默认的值发送出去。 我们需要根据 Cookie 的版本和变种检测每个属性是否有效
        // （关于这条的详细信息，参见 RFC 文档）
        //
        // 这个函数只有在如下情况才能正常工作
        //   1.  Cookie 使用缺省的 URI （响应 URI）创建后
        //   2.  setDefault 值为 true
        // 这之后，这个函数会被调用多次，那时，URI 和 setDefault 可能不是原始值，这样我们
        // 就检测这个新的 Cookie 是否满足给定的 URI。

        internal bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool setDefault, bool shouldThrow) {
            string host = uri.Host;
            int port = uri.Port;
            string path = uri.AbsolutePath;
            bool valid = true;

            if (setDefault) {
                // Set Variant. If version is zero => reset cookie to Version0 style
                if (Version == 0) {
                    variant = CookieVariant.Plain;
                } else if (Version == 1 && variant == CookieVariant.Unknown) {
                    // Since we don't expose Variant to an app, set it to Default
                    variant = CookieVariant.Default;
                }
                m_cookieVariant = variant;
            }

            // 检查名称

            if (string.IsNullOrEmpty(m_name) || m_name[0] == '$' || m_name.IndexOfAny(ReservedToName) != -1 || m_name[0] == ' ' || m_name[m_name.Length - 1] == ' ') {
                if (shouldThrow) {
                    throw new CookieException(SR.Format(SR.net_cookie_attribute, "Name", m_name == null ? "<null>" : m_name));
                }
                return false;
            }

            // 检查值

            if (m_value == null ||
                (!(m_value.Length > 2 && m_value[0] == '\"' && m_value[m_value.Length - 1] == '\"') && m_value.IndexOfAny(ReservedToValue) != -1)) {
                if (shouldThrow) {
                    throw new CookieException(SR.Format(SR.net_cookie_attribute, "Value", m_value == null ? "<null>" : m_value));
                }
                return false;
            }

            // 检查注释语法

            if (Comment != null && !(Comment.Length > 2 && Comment[0] == '\"' && Comment[Comment.Length - 1] == '\"')
                && (Comment.IndexOfAny(ReservedToValue) != -1)) {
                if (shouldThrow) {
                    throw new CookieException(SR.Format(SR.net_cookie_attribute, CookieFields.CommentAttributeName, Comment));
                }
                return false;
            }

            // 检查 Path 语法

            if (Path != null && !(Path.Length > 2 && Path[0] == '\"' && Path[Path.Length - 1] == '\"')
                && (Path.IndexOfAny(ReservedToValue) != -1)) {
                if (shouldThrow) {
                    throw new CookieException(SR.Format(SR.net_cookie_attribute, CookieFields.PathAttributeName, Path));
                }
                return false;
            }

            // 检查，重设 Domain ：
            // 如果一个 Domain 是不明确的，确认 1. Uri 是合法的 2. 将 Domain 设置成 Uri 的主机名

            if (setDefault && m_domain_implicit == true) {
                m_domain = host;
            } else {
                if (!m_domain_implicit) {

                    // 注意： 如果 Uri.Host 是 IP 地址的形式，那么我们只支持未设置（不明确）的
                    // Domain 属性。 下面的代码会尝试解析 Uri.Host 的 IP 地址，并把它解析成 fqdn 再拒绝 Cookie。
                    // 给 Domain 起别名，因为我们需要 KeyValue 而不是原始值。

                    string domain = m_domain;

                    // Syntax check for Domain charset plus empty string.
                    if (!DomainCharsTest(domain)) {
                        if (shouldThrow) {
                            throw new CookieException(SR.Format(SR.net_cookie_attribute, CookieFields.DomainAttributeName, domain == null ? "<null>" : domain));
                        }
                        return false;
                    }

                    // 如果显式声明，Domain 必须以 '.' 开头

                    if (domain[0] != '.') {
                        if (!(variant == CookieVariant.Rfc2965 || variant == CookieVariant.Plain)) {
                            if (shouldThrow) {
                                throw new CookieException(SR.Format(SR.net_cookie_attribute, CookieFields.DomainAttributeName, m_domain));
                            }
                            return false;
                        }
                        domain = '.' + domain;
                    }

                    int host_dot = host.IndexOf('.');

                    // 快速检查，以把 Cookie 推入本地域名中

                    if (isLocalDomain && string.Equals(localDomain, domain, StringComparison.OrdinalIgnoreCase)) {
                        valid = true;
                    } else if (domain.IndexOf('.', 1, domain.Length - 2) == -1) {

                        // 单标记名只在当域名和 Uri 指定的主机名完全一样是才是合法的

                        if (!IsDomainEqualToHost(domain, host)) {
                            valid = false;
                        }
                    } else if (variant == CookieVariant.Plain) {

                        // 在域名上，我们应该分别处理 Version0 和其他版本的 Cookie。
                        // 在 Version0 规定下，域名必须只是主机名的部分字符串。

                        if (!IsDomainEqualToHost(domain, host)) {
                            if (host.Length <= domain.Length ||
                                (string.Compare(host, host.Length - domain.Length, domain, 0, domain.Length, StringComparison.OrdinalIgnoreCase) != 0)) {
                                valid = false;
                            }
                        }
                    } else if (host_dot == -1 ||
                               domain.Length != host.Length - host_dot ||
                               (string.Compare(host, host_dot, domain, 0, domain.Length, StringComparison.OrdinalIgnoreCase) != 0)) {
                        
                        // 从第一个 '.' 开始，主机名必须和域名相匹配
                        // 对于主机是 null 的情况，主机名和域名必须完全一样。
                        
                        if (!IsDomainEqualToHost(domain, host)) {
                            valid = false;
                        }
                    }

                    if (valid) {
                        m_domainKey = domain.ToLowerInvariant();
                    }
                } else {

                    // 隐式的设置 Domain 并且 set_default 是 false 时，
                    // 我们只需要将 uri.Host 和 m_domain 匹配即可

                    if (!string.Equals(host, m_domain, StringComparison.OrdinalIgnoreCase)) {
                        valid = false;
                    }
                }
                if (!valid) {
                    if (shouldThrow) {
                        throw new CookieException(SR.Format(SR.net_cookie_attribute, CookieFields.DomainAttributeName, m_domain));
                    }
                    return false;
                }
            }

            // Check/Set Path
            if (setDefault && m_path_implicit == true) {

                // 这段代码已经假定 Uri 路径总是合法的，且后面跟着至少一个 '/'

                switch (m_cookieVariant) {
                    case CookieVariant.Plain:
                        m_path = path;
                        break;
                    case CookieVariant.Rfc2109:
                        m_path = path.Substring(0, path.LastIndexOf('/')); // May be empty
                        break;

                    case CookieVariant.Rfc2965:
                    default:

                        // 此代码对具有不同“路径”语义的将来版本没有弹性。

                        m_path = path.Substring(0, path.LastIndexOf('/') + 1);
                        break;
                }
            } else {

                // 用给定的 Uri 路径检查当前路径

                if (!path.StartsWith(CookieParser.CheckQuoted(m_path), StringComparison.Ordinal)) {
                    if (shouldThrow) {
                        throw new CookieException(SR.Format(SR.net_cookie_attribute, CookieFields.PathAttributeName, m_path));
                    }
                    return false;
                }
            }

            // 如果“端口”属性存在但没有值，则设置默认端口。

            if (setDefault && (m_port_implicit == false && m_port.Length == 0)) {
                m_port_list = new int[1] { port };
            }

            if (m_port_implicit == false) {

                // 端口必须与 uri 中的端口匹配。

                valid = false;
                foreach (int p in m_port_list!) {
                    if (p == port) {
                        valid = true;
                        break;
                    }
                }
                if (!valid) {
                    if (shouldThrow) {
                        throw new CookieException(SR.Format(SR.net_cookie_attribute, CookieFields.PortAttributeName, m_port));
                    }
                    return false;
                }
            }
            return true;
        }

        // 非常原始的测试，以确保名称没有非法字符
        // 根据RFC 952（在第一个字符上可以是数字，字符串可以有'_'）。

        private static bool DomainCharsTest(string name) {
            if (name == null || name.Length == 0) {
                return false;
            }
            for (int i = 0; i < name.Length; ++i) {
                char ch = name[i];
                if (!((ch >= '0' && ch <= '9') ||
                      (ch == '.' || ch == '-') ||
                      (ch >= 'a' && ch <= 'z') ||
                      (ch >= 'A' && ch <= 'Z') ||
                      (ch == '_'))) {
                    return false;
                }
            }
            return true;
        }

        [AllowNull]
        public string Port {
            get {
                return m_port;
            }
            set {
                m_port_implicit = false;
                if (string.IsNullOrEmpty(value)) {

                    // "Port" 存在，但是没有值

                    m_port = string.Empty;
                } else {

                    // 解析端口列表

                    if (value[0] != '\"' || value[value.Length - 1] != '\"') {
                        throw new CookieException(SR.Format(SR.net_cookie_attribute, CookieFields.PortAttributeName, value));
                    }
                    string[] ports = value.Split(PortSplitDelimiters);

                    List<int> portList = new List<int>();
                    int port;

                    for (int i = 0; i < ports.Length; ++i) {

                        // 跳过空格

                        if (ports[i] != string.Empty) {
                            if (!int.TryParse(ports[i], out port)) {
                                throw new CookieException(SR.Format(SR.net_cookie_attribute, CookieFields.PortAttributeName, value));
                            }

                            // 端口的合理数值： 0 - 0xFFFF

                            if ((port < 0) || (port > 0xFFFF)) {
                                throw new CookieException(SR.Format(SR.net_cookie_attribute, CookieFields.PortAttributeName, value));
                            }

                            portList.Add(port);
                        }
                    }
                    m_port_list = portList.ToArray();
                    m_port = value;
                    m_version = MaxSupportedVersion;
                    m_cookieVariant = CookieVariant.Rfc2965;
                }
            }
        }


        internal int[]? PortList {
            get {
                // PortList will be null if Port Attribute was omitted in the response.
                return m_port_list;
            }
        }

        public bool Secure {
            get {
                return m_secure;
            }
            set {
                m_secure = value;
            }
        }

        public DateTime TimeStamp {
            get {
                return m_timeStamp;
            }
        }

        [AllowNull]
        public string Value {
            get {
                return m_value;
            }
            set {
                m_value = value ?? string.Empty;
            }
        }

        internal CookieVariant Variant {
            get {
                return m_cookieVariant;
            }
        }

        // _domainKey 成员是在 VerifySetDefaults() 内部设置的。
        // 如果未设置，则不调用验证功能；这永远都不会发生。

        internal string DomainKey {
            get {
                return m_domain_implicit ? Domain : m_domainKey;
            }
        }

        public int Version {
            get {
                return m_version;
            }
            set {
                if (value < 0) {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                m_version = value;
                if (value > 0 && m_cookieVariant < CookieVariant.Rfc2109) {
                    m_cookieVariant = CookieVariant.Rfc2109;
                }
            }
        }

        public override bool Equals(object? comparand) {
            Cookie? other = comparand as Cookie;

            return other != null
                    && string.Equals(Name, other.Name, StringComparison.OrdinalIgnoreCase)
                    && string.Equals(Value, other.Value, StringComparison.Ordinal)
                    && string.Equals(Path, other.Path, StringComparison.Ordinal)
                    && string.Equals(Domain, other.Domain, StringComparison.OrdinalIgnoreCase)
                    && (Version == other.Version);
        }

        public override int GetHashCode() {
            return (Name + "=" + Value + ";" + Path + "; " + Domain + "; " + Version).GetHashCode();
        }

        public override string ToString() {
            StringBuilder sb = StringBuilderCache.Acquire();
            ToString(sb);
            return StringBuilderCache.GetStringAndRelease(sb);
        }

        internal void ToString(StringBuilder sb) {
            int beforeLength = sb.Length;

            // 如果需要，就加上 Cookie 的版本

            if (Version != 0) {
                sb.Append(SpecialAttributeLiteral + CookieFields.VersionAttributeName + EqualsLiteral); // const strings
                if (IsQuotedVersion) sb.Append('"');
                sb.Append(m_version.ToString(NumberFormatInfo.InvariantInfo));
                if (IsQuotedVersion) sb.Append('"');
                sb.Append(SeparatorLiteral);
            }

            // 加上 Name = Value 对

            sb.Append(Name).Append(EqualsLiteral).Append(Value);

            if (!Plain) {

                // 如果必须，就加上路径

                if (!m_path_implicit && m_path.Length > 0) {
                    sb.Append(SeparatorLiteral + SpecialAttributeLiteral + CookieFields.PathAttributeName + EqualsLiteral); // const strings
                    sb.Append(m_path);
                }

                // 如果必须，就加上域名

                if (!m_domain_implicit && m_domain.Length > 0) {
                    sb.Append(SeparatorLiteral + SpecialAttributeLiteral + CookieFields.DomainAttributeName + EqualsLiteral); // const strings
                    if (IsQuotedDomain) sb.Append('"');
                    sb.Append(m_domain);
                    if (IsQuotedDomain) sb.Append('"');
                }
            }

            // 如果必须，就加上端口

            if (!m_port_implicit) {
                sb.Append(SeparatorLiteral + SpecialAttributeLiteral + CookieFields.PortAttributeName); // const strings
                if (m_port.Length > 0) {
                    sb.Append(EqualsLiteral);
                    sb.Append(m_port);
                }
            }

            // 检查我们是否只加上了一个单独的 '='
            // 如果是这样，我们就删掉它，让 StringBuilder 保持不变

            int afterLength = sb.Length;
            if (afterLength == (1 + beforeLength) && sb[beforeLength] == '=') {
                sb.Length = beforeLength;
            }
        }

        internal string? ToServerString() {
            string result = Name + EqualsLiteral + Value;
            if (m_comment != null && m_comment.Length > 0) {
                result += SeparatorLiteral + CookieFields.CommentAttributeName + EqualsLiteral + m_comment;
            }
            if (m_commentUri != null) {
                result += SeparatorLiteral + CookieFields.CommentUrlAttributeName + EqualsLiteral + QuotesLiteral + m_commentUri.ToString() + QuotesLiteral;
            }
            if (m_discard) {
                result += SeparatorLiteral + CookieFields.DiscardAttributeName;
            }
            if (!m_domain_implicit && m_domain != null && m_domain.Length > 0) {
                result += SeparatorLiteral + CookieFields.DomainAttributeName + EqualsLiteral + m_domain;
            }
            if (Expires != DateTime.MinValue) {
                int seconds = (int)(Expires.ToLocalTime() - DateTime.Now).TotalSeconds;
                if (seconds < 0) {

                    // 这意味着 Cookie 已经过期，加上 Max-Age = 0
                    // 这样，客户端就会立即刷星这个 Cookie。

                    seconds = 0;
                }
                result += SeparatorLiteral + CookieFields.MaxAgeAttributeName + EqualsLiteral + seconds.ToString(NumberFormatInfo.InvariantInfo);
            }
            if (!m_path_implicit && m_path != null && m_path.Length > 0) {
                result += SeparatorLiteral + CookieFields.PathAttributeName + EqualsLiteral + m_path;
            }
            if (!Plain && !m_port_implicit && m_port != null && m_port.Length > 0) {

                // 引号字段已经包含在 _port 内了

                result += SeparatorLiteral + CookieFields.PortAttributeName + EqualsLiteral + m_port;
            }
            if (m_version > 0) {
                result += SeparatorLiteral + CookieFields.VersionAttributeName + EqualsLiteral + m_version.ToString(NumberFormatInfo.InvariantInfo);
            }
            return result == EqualsLiteral ? null : result;
        }
    }
}
#endif
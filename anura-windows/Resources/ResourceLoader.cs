using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Anura.Windows.Resources {
    public static class ResourceLoader {
        
        // 从默认的资源文件夹中加载程序需要的资源.
        // 此函数只能适配于 Windows 操作系统，请勿在 Anura Core 项目中使用.
        // 在开启 Anura 调试模式时，它将返回 anura-resources 中的目录
        //
        // param: locator
        //     标识资源的位置，以资源的内部文件夹(不以'/'开头)，统一左斜杠。
        //     例如'application/logo/anura.ico'
        // return:
        //     返回加载的图片 System.Drawing.Bitmap, System.Drawing.Icon.
        
        public static Bitmap LoadBitmap(string locator) {
            return new Bitmap(Global.GetDefaultResourcePath() + locator.Replace(@"/",@"\"));
        }

        public static Icon LoadIcon(string locator) {
            return new Icon(Global.GetDefaultResourcePath() + locator.Replace(@"/",@"\"));
        }
    }
}
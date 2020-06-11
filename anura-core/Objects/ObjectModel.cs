using System.Collections.Generic;

namespace Anura.Objects
{
    /// <summary>
    /// 这个类代表 .NET 对象模型对 JS 对象的翻译. 
    /// 每一个允许在网页 JavaScript 类型都应继承此类
    /// </summary>
    public interface IPrototypeObjectModel
    {
        void Configure();
        JavaScript.Native.Object.ObjectInstance PrototypeObject { get; set; }
    }

    public class Initialization
    {
        public static int GlobalCapacity = 40;

        public static void CreateConstructors(JavaScript.Engine engine) {

        }

        public static void Configure(JavaScript.Engine engine) {
            foreach (var item in ExtensionWebAPIs) {
                switch (item.config) {
                    case 0:
                        IPrototypeObjectModel constr = item.obj as IPrototypeObjectModel;
                        constr.Configure();
                        (constr.PrototypeObject as IPrototypeObjectModel).Configure();
                        break;
                }
            }
        }

        public static void RegisterGlobalObjects(JavaScript.Collections.PropertyDictionary inst,
            JavaScript.Runtime.Descriptors.PropertyFlag defaultFlag) {
            
        }

        public static List<(int config, IPrototypeObjectModel obj)> ExtensionWebAPIs = new List<(int config, IPrototypeObjectModel obj)>();
    }
}
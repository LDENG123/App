using System.ComponentModel.Composition;
using System.Globalization;
using System.Resources;
namespace WpfApp1.Resource
{
    [Export(typeof(IResource))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class MyResource :  IResource
    {
        
        private ResourceManager stringResource;
        private CultureInfo culture = new CultureInfo("zh-cn");
        public CultureInfo CurrentCulture
        {
            get
            {
                return culture;
            }
            set
            {
                culture = value;
            }
        }
        
        public MyResource()
        {
            stringResource = new ResourceManager("WpfApp1.Resource.MyLanguage", typeof(MyResource).Assembly);
        }
       

        public string GetString(string name)
        {
            return stringResource.GetString(name, culture);
        }

        
    }
}

namespace DesignPatternSamples.CreationalPattern.Factory.Sample1
{
    internal class MobileOSFactory
    {
        public IMobileOS GetMobileOSInstance(string OSName)
        {
            IMobileOS mobileOS;
            switch (OSName)
            {
                case "Android":
                    mobileOS = new AndroidOS();
                    break;
                case "iOS":
                    mobileOS = new IOS();
                    break;
                case "WindowsPhone":
                    mobileOS = new WindowsPhone();
                    break;
                default:
                    throw new NotImplementedException();
            }

            return mobileOS;
        }
    }
}

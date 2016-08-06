using System.Collections.Generic;

namespace UltronCloud
{
    class Integrations
    {
        public static List<Integration> IntegrationList { get; private set; }

        //static MounterHack hacks;

        public static void Initialize()
        {
            //hacks = new MounterHack();
        }

        public static List<Integration> GetSupportedIntegrations()
        {
            //var list = new List<Integration>();
            //foreach (DriveElement drive in hacks.GetIntegrations())
            //{
            //    list.Add(new Integration(drive.Schema));
            //}
            //return list;

            return new List<Integration> { new DropboxIntegration(), new GDriveIntegration(), new OneDriveIntegration() };
        }
    }
}

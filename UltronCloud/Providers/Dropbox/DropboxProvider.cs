using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dropbox.Api;

namespace UltronCloud.Providers.Dropbox
{
    class DropboxProvider
    {
        DropboxClient client;

        public DropboxProvider()
        {
            client = new DropboxClient("oauth2AccessToken");
        }

        public async Task<string> getAcctName()
        {
            var acct = await client.Users.GetCurrentAccountAsync();
            return String.Format("{0} ({1})", acct.Name.FamiliarName, acct.Name.DisplayName);
        }
    }
}

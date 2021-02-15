using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignService
    {
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}

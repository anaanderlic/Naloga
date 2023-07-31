using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RazpolozljivostProdukta
{
    internal class Izdelek
    {
        private int id;
        private DateTime onlineDate = new DateTime();
        private DateTime offlineDate = new DateTime();
        private string approvalStatus;

        public Izdelek(int _id, DateTime onlineD, DateTime offlineD, string approvalStatus) 
        {
            Id = _id;
            OnlineDate = onlineD;
            OfflineDate = offlineD;
            ApprovalStatus = approvalStatus;
        }

        public Izdelek(int _id, DateTime onlineD, string approvalStatus)
        {
            Id = _id;
            OnlineDate = onlineD;
            ApprovalStatus = approvalStatus;
        }

        public Izdelek(int _id, string approvalStatus, DateTime offlineD)
        {
            Id = _id;
            OfflineDate = offlineD;
            ApprovalStatus = approvalStatus;
        }

        public Izdelek(int _id, string approvalStatus)
        {
            Id = _id;
            ApprovalStatus = approvalStatus;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private DateTime OnlineDate
        {
            get { return onlineDate; }
            set { onlineDate = value; }
        }

        private DateTime OfflineDate
        {
            get { return offlineDate; }
            set { offlineDate = value; }
        }

        private string ApprovalStatus
        {
            get { return approvalStatus; }
            set { approvalStatus = value; }
        }

        public override string ToString()
        {

            return $"Izdelek z id-jem {this.Id}";
        }

        public bool Availability ()
        {
            if ((OnlineDate == DateTime.MinValue || OnlineDate <= DateTime.Today) 
                && (OfflineDate == DateTime.MinValue || OfflineDate >= DateTime.Today)
                && ApprovalStatus == "approved")
            {
                return true ;
            }

            else
            {
                return false;
            }
        }
    }
}

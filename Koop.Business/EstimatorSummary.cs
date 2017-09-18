using Koop.Data.EntityClasses;
using Koop.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Collections;
using System.Data;
using System.Linq;

namespace Koop.Business
{
    public class EstimatorSummary
    {
        private int _estimatorId;
        private string _username;
        private decimal _totalContracted;
        private decimal _totalBilled;
        private decimal _totalPayments;
        private decimal _totalExpenses;
        private decimal _projected;
        private int _jobCount;

        public int EstimatorId
        {
            get
            {
                return this._estimatorId;
            }

            set
            {
                this._estimatorId = value;
            }
        }

        public string Username
        {
            get
            {
                return this._username;
            }

            set
            {
                this._username = value;
            }
        }

        public decimal TotalContracted
        {
            get
            {
                return this._totalContracted;
            }

            set
            {
                this._totalContracted = value;
            }
        }

        public decimal TotalBilled
        {
            get
            {
                return this._totalBilled;
            }

            set
            {
                this._totalBilled = value;
            }
        }

        public decimal TotalPayments
        {
            get
            {
                return this._totalPayments;
            }

            set
            {
                this._totalPayments = value;
            }
        }

        public decimal TotalExpenses
        {
            get
            {
                return this._totalExpenses;
            }

            set
            {
                this._totalExpenses = value;
            }
        }

        public decimal Projected
        {
            get
            {
                return this._projected;
            }

            set
            {
                this._projected = value;
            }
        }

        public int JobCount
        {
            get
            {
                return this._jobCount;
            }

            set
            {
                this._jobCount = value;
            }
        }

        public EstimatorSummary()
        {
            this._username = string.Empty;
            this._totalContracted = new decimal(10, 0, 0, true, 1);
            this._totalBilled = new decimal(10, 0, 0, true, 1);
            this._totalPayments = new decimal(10, 0, 0, true, 1);
            this._totalExpenses = new decimal(10, 0, 0, true, 1);
            this._projected = new decimal(10, 0, 0, true, 1);
            this._jobCount = -1;
        }
    }
}

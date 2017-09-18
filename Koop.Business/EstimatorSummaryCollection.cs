using Koop.Data.EntityClasses;
using Koop.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Security.Principal;

namespace Koop.Business
{
    public class EstimatorSummaryCollection : CollectionBase
    {
        private decimal _totalProjected;
        private readonly JobTrackerPrincipal _principal;
        private readonly IDataAccessAdapter _adapter;

        public EstimatorSummaryCollection(JobTrackerPrincipal principal, IDataAccessAdapter adapter)
        {
            _principal = principal;
            this._adapter = adapter;
        }

        public EstimatorSummary this[int index]
        {
            get
            {
                return (EstimatorSummary)this.List[index];
            }

            set
            {
                this.List[index] = value;
            }
        }

        public decimal TotalProjected
        {
            get
            {
                return this._totalProjected;
            }
        }

        public EstimatorSummaryCollection()
        {
            this._totalProjected = new decimal(0, 0, 0, false, 1);
        }

        public EstimatorSummaryCollection(int capacity) : base(capacity)
        {
            this._totalProjected = new decimal(0, 0, 0, false, 1);
        }

        public void Add(EstimatorSummary summary)
        {
            this.List.Add(summary);
        }

        public void LoadFromDataSource()
        {
            List.Clear();
            _totalProjected = new decimal(0, 0, 0, false, 1);
            //IDataAccessAdapter adapter = DataAccessAdapterFactory.Create();
            IRelationCollection relationsToUse = new RelationCollection();
            relationsToUse.Add(JobEntity.Relations.BillingEntityUsingJobId);
            relationsToUse.ObeyWeakRelations = true;
            IRelationCollection relationsToUse1 = new RelationCollection();
            relationsToUse1.Add(JobEntity.Relations.PaymentEntityUsingJobId);
            relationsToUse1.ObeyWeakRelations = true;
            IRelationCollection relationsToUse2 = new RelationCollection();
            relationsToUse2.Add(JobEntity.Relations.ExpenseEntityUsingJobId);
            relationsToUse2.ObeyWeakRelations = true;
            ResultsetFields fieldCollectionToFetch = new ResultsetFields(7);
            fieldCollectionToFetch.DefineField(PersonFields.PersonId, 0, "EstimatorId");
            fieldCollectionToFetch.DefineField(PersonFields.Username, 1);
            fieldCollectionToFetch.DefineField(new EntityField2("ContractedAmounts", new ScalarQueryExpression(JobFields.ContractedAmount.SetAggregateFunction(AggregateFunction.Sum), PersonFields.PersonId == JobFields.EstimatorId)), 2);
            fieldCollectionToFetch.DefineField(new EntityField2("Billings", new ScalarQueryExpression(BillingFields.Amount.SetAggregateFunction(AggregateFunction.Sum), PersonFields.PersonId == JobFields.EstimatorId & JobFields.JobId == BillingFields.JobId, relationsToUse)), 3);
            fieldCollectionToFetch.DefineField(new EntityField2("Payments", new ScalarQueryExpression(PaymentFields.Amount.SetAggregateFunction(AggregateFunction.Sum), PersonFields.PersonId == JobFields.EstimatorId & JobFields.JobId == PaymentFields.JobId, relationsToUse1)), 4);
            IEntityField2 selectField = new EntityField2("Expenses", ExpenseFields.LaborHours * ExpenseFields.LaborRate + ExpenseFields.MaterialCost, AggregateFunction.Sum);
            fieldCollectionToFetch.DefineField(new EntityField2("Expenses", new ScalarQueryExpression(selectField, PersonFields.PersonId == JobFields.EstimatorId & JobFields.JobId == ExpenseFields.JobId, relationsToUse2)), 5);
            fieldCollectionToFetch.DefineField(new EntityField2("JobCount", new ScalarQueryExpression(JobFields.JobId.SetAggregateFunction(AggregateFunction.Count), PersonFields.PersonId == JobFields.EstimatorId)), 6);
            DataTable dataTableToFill = new DataTable("EstimatorSummary");
            _adapter.OpenConnection();
            bool flag = _principal.Role != JobTrackerRoles.Estimator && _principal.Role != JobTrackerRoles.Unidentified;
            if (flag)
            {
                _adapter.FetchTypedList(fieldCollectionToFetch, dataTableToFill, null);
            }
            else
            {
                _adapter.FetchTypedList(fieldCollectionToFetch, dataTableToFill, new RelationPredicateBucket(PersonFields.PersonId == _principal.PersonId));
            }

            _adapter.CloseConnection();
            IEnumerator enumerator = dataTableToFill.Rows.GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {
                    DataRow dr = (DataRow)enumerator.Current;
                    flag = dr[0] != DBNull.Value;
                    if (!flag)
                    {
                        continue;
                    }

                    EstimatorSummary summary = new EstimatorSummary();
                    summary.EstimatorId = (int)dr[0];
                    summary.Username = dr[1] != DBNull.Value ? ((string)dr[1]) : "";
                    summary.TotalContracted = dr[2] != DBNull.Value ? ((decimal)dr[2]) : (new decimal(0, 0, 0, false, 1));
                    summary.TotalBilled = dr[3] != DBNull.Value ? ((decimal)dr[3]) : (new decimal(0, 0, 0, false, 1));
                    summary.TotalPayments = dr[4] != DBNull.Value ? ((decimal)dr[4]) : (new decimal(0, 0, 0, false, 1));
                    summary.Projected = summary.TotalContracted - summary.TotalPayments;
                    summary.TotalExpenses = dr[5] != DBNull.Value ? ((decimal)dr[5]) : (new decimal(0, 0, 0, false, 1));
                    summary.JobCount = dr[6] != DBNull.Value ? ((int)dr[6]) : 0;
                    _totalProjected += summary.Projected;
                    this.Add(summary);
                }
            }
            finally
            {
                IDisposable disposable = enumerator as IDisposable;
                flag = disposable == null;
                if (!flag)
                {
                    disposable.Dispose();
                }
            }
        }
    }
}

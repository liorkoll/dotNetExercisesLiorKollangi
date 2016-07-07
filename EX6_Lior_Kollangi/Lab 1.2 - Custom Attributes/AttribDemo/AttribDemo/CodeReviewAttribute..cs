using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttribDemo
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct ,
        AllowMultiple =true)]        
    public sealed class CodeReviewAttribute : Attribute
    {
        private readonly string _reviewerName;
        private readonly DateTime _reviewerDate;
        private readonly bool _approved;

        public string ReviewerName
        {
            get
            {
                return _reviewerName;
            }
        }
        public DateTime ReviewerDate
        {
            get
            {
                return _reviewerDate;
            }
        }
        public bool Approved
        {
            get
            {
                return _approved;
            }
        }
        public CodeReviewAttribute(string name, string date,bool approved)
        {
            _reviewerName = name;
            _reviewerDate = DateTime.Parse(date);
            _approved = approved;
        }
        


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    public interface IAppraise
    {
        int AgreeAmount { get; set; }

        int DisagreeAmount { get; set; }

        void Agreedby(User voter);

        void Disagreedby(User voter);
    }
}

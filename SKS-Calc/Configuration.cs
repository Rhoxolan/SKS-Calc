using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKS_Calc
{
    public record Configuration(DateTime RecordTime, double MinPermamentLink, double MaxPermamentLink,
        double AveragePermamentLink, int NumberOfPorts, double СableQuantity, double? HankQuantity,
        double? TotalСableQuantity)
    {
        public override string ToString()
        {
            if(HankQuantity!=null)
            {
                return $"{RecordTime.ToString()}, мин.{MinPermamentLink} м / макс.{MaxPermamentLink} м," +
                    $"{HankQuantity} бухт; {TotalСableQuantity} м.";
            }
            else
            {
                return $"{RecordTime.ToString()}, мин.{MinPermamentLink} м / макс.{MaxPermamentLink} м;" +
                    $"{TotalСableQuantity} м.";
            }
        }
    }
}

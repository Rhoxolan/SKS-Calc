﻿namespace SKS_Calc
{
    public record Configuration(DateTime RecordTime, double MinPermamentLink, double MaxPermamentLink,
        double AveragePermamentLink, int NumberOfWorkplaces, int NumberOfPorts, double? СableQuantity,
        double? CableHankMeterage, int? HankQuantity, double TotalСableQuantity)
    {
        public override string ToString()
        {
            if(CableHankMeterage != null)
            {
                return $"{RecordTime.ToString()}, мин.{MinPermamentLink.ToString("F" + 2)} м / макс.{MaxPermamentLink.ToString("F" + 2)} м, " +
                    $"{HankQuantity} бухт; {TotalСableQuantity.ToString("F" + 2)} м.";
            }
            else
            {
                return $"{RecordTime.ToString()}, мин.{MinPermamentLink.ToString("F" + 2)} м / макс.{MaxPermamentLink.ToString("F" + 2)} м; " +
                    $"{TotalСableQuantity.ToString("F" + 2)} м.";
            }
        }
    }
}

namespace SKS_Calc
{
    //Методы расширения класса Configuration. Методы создаются для удобства работы с объектами
    //класса Configuration в разных частях приложения, в частности в разных UserControl-ах.
    //Создание методов в этом классе не регламентировано, методы создаются по мере необходимости.
    public static class ConfigurationExtension
    {
        public static string ToLongOutputString(this Configuration configuration)
        {
            if (configuration.СableQuantity != null && configuration.HankQuantity != null)
            {
                return
                    $"{configuration.RecordTime.ToString()}{Environment.NewLine}" +
                    $"Наименьшая длина постоянного линка (Permament Link): " +
                    $"{configuration.MinPermamentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Наибольшая длина постоянного линка (Permament Link): " +
                    $"{configuration.MaxPermamentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Средняя длина постоянного линка (Permament Link): " +
                    $"{configuration.AveragePermamentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Количество рабочих мест: " +
                    $"{configuration.NumberOfWorkplaces}{Environment.NewLine}" +
                    $"Количество портов на 1 рабочее место: " +
                    $"{configuration.NumberOfPorts}{Environment.NewLine}" +
                    $"Необходимое количество кабеля: " +
                    $"{configuration.СableQuantity?.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Необходимое количество бухт кабеля: " +
                    $"{configuration.HankQuantity}{Environment.NewLine}" +
                    $"Итоговое необходимое количество кабеля: " +
                    $"{configuration.TotalСableQuantity.ToString("F" + 2)}{Environment.NewLine}";
            }
            else
            {
                return
                    $"{configuration.RecordTime.ToString()}{Environment.NewLine}" +
                    $"Наименьшая длина постоянного линка (Permament Link): " +
                    $"{configuration.MinPermamentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Наибольшая длина постоянного линка (Permament Link): " +
                    $"{configuration.MaxPermamentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Средняя длина постоянного линка (Permament Link): " +
                    $"{configuration.AveragePermamentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Количество рабочих мест: " +
                    $"{configuration.NumberOfWorkplaces}{Environment.NewLine}" +
                    $"Количество портов на 1 рабочее место: " +
                    $"{configuration.NumberOfPorts}{Environment.NewLine}" +
                    $"Итоговое необходимое количество кабеля: " +
                    $"{configuration.TotalСableQuantity.ToString("F" + 2)}{Environment.NewLine}";
            }
        }

        public static string ToLongSaveString(this Configuration configuration)
        {
            if (configuration.СableQuantity != null && configuration.HankQuantity != null)
            {
                return
                    $"Конфигурация создана в приложении SCS-Calc{Environment.NewLine}{Environment.NewLine}" +
                    $"Дата записи конфигурации: {configuration.RecordTime.ToString()}{Environment.NewLine}" +
                    $"Наименьшая длина постоянного линка (Permament Link): " +
                    $"{configuration.MinPermamentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Наибольшая длина постоянного линка (Permament Link): " +
                    $"{configuration.MaxPermamentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Средняя длина постоянного линка (Permament Link): " +
                    $"{configuration.AveragePermamentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Количество рабочих мест: " +
                    $"{configuration.NumberOfWorkplaces}{Environment.NewLine}" +
                    $"Количество портов на 1 рабочее место: " +
                    $"{configuration.NumberOfPorts}{Environment.NewLine}" +
                    $"Необходимое количество кабеля: " +
                    $"{configuration.СableQuantity?.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Необходимое количество бухт кабеля: " +
                    $"{configuration.HankQuantity?.ToString()}{Environment.NewLine}" +
                    $"Итоговое необходимое количество кабеля: " +
                    $"{configuration.TotalСableQuantity.ToString("F" + 2)} м.{Environment.NewLine}";
            }
            else
            {
                return
                    $"Конфигурация создана в приложении SCS-Calc{Environment.NewLine}{Environment.NewLine}" +
                    $"Дата записи конфигурации: {configuration.RecordTime.ToString()}{Environment.NewLine}" +
                    $"Наименьшая длина постоянного линка (Permament Link):" +
                    $"{configuration.MinPermamentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Наибольшая длина постоянного линка (Permament Link): " +
                    $"{configuration.MaxPermamentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Средняя длина постоянного линка (Permament Link): " +
                    $"{configuration.AveragePermamentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Количество рабочих мест: " +
                    $"{configuration.NumberOfWorkplaces}{Environment.NewLine}" +
                    $"Количество портов на 1 рабочее место: " +
                    $"{configuration.NumberOfPorts}{Environment.NewLine}" +
                    $"Итоговое необходимое количество кабеля: " +
                    $"{configuration.TotalСableQuantity.ToString("F" + 2)} м.{Environment.NewLine}";
            }
        }
    }
}

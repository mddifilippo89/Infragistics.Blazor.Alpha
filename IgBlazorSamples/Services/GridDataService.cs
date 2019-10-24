using IgBlazorSamples.Business;
using System;
using System.Collections.Generic;

namespace IgBlazorSamples.Services
{
    public class GridDataService
    {
        public List<GridItem> GridItems { get; set; }

        public GridDataService()
        {
            GenerateData();
        }

        private void GenerateData()
        {
            GridItems = new List<GridItem>();

            for (int x = 0; x <= 100000; x++)
            {
                var item = new GridItem();
                item.Id = x;
                item.Name = $"Name: {x}";
                item.Age = new Random().Next(18, 65);
                item.Birthday = DateTime.Now.AddYears(-item.Age);
                item.IsActive = x % 2 == 0;

                GridItems.Add(item);
            }
        }
    }
}

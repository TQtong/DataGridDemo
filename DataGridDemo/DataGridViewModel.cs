using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridDemo
{
    public class DataGridViewModel : BindableObject
    {
        public ObservableCollection<DataGridModel> DataGridModels { get; set; } = new ObservableCollection<DataGridModel>();

        public DataGridViewModel()
        {
            Create();
        }

        private void Create()
        {
            DataGridModels.Add(new DataGridModel()
            {
                Name = "苹果",
                Number = 5,
                Price = 1.5
            });
            DataGridModels.Add(new DataGridModel()
            {
                Name = "香蕉",
                Number = 2,
                Price = 15
            });
            DataGridModels.Add(new DataGridModel()
            {
                Name = "菠萝",
                Number = 3,
                Price = 10
            });
            DataGridModels.Add(new DataGridModel()
            {
                Name = "葡萄",
                Number = 6,
                Price = 12
            });
            DataGridModels.Add(new DataGridModel()
            {
                Name = "椰子",
                Number = 10,
                Price = 30
            });
        }
    }
}

using grhwrrh.View;
using System.Collections.ObjectModel;
using System.Windows;

namespace grhwrrh.ViewModel
{
    internal class AddWindowVM : BaseVM
    {
        private ObservableCollection<object> items;

        public CommandVM GpuAdd { get; }
        public CommandVM CpuAdd { get; }
        public CommandVM RamAdd { get; }
        public CommandVM MomAdd { get; }

        public AddWindowVM(ObservableCollection<object> items)
        {
            this.items = items;

            GpuAdd = new CommandVM(() =>
            {
                WindowNewGPU windowNewGPU = new WindowNewGPU();
                windowNewGPU.ShowDialog();
                items.Add(windowNewGPU.NewGPU);
            });

            CpuAdd = new CommandVM(() =>
            {
                WindowNewCPU windowNewCPU = new WindowNewCPU();
                windowNewCPU.ShowDialog();
                items.Add(windowNewCPU.NewCPU);
            });

            RamAdd = new CommandVM(() =>
            {
                WindowNewRAM windowNewRAM = new WindowNewRAM();
                windowNewRAM.ShowDialog();
                items.Add(windowNewRAM.NewRAM);
            });

            MomAdd = new CommandVM(() =>
            {
                WindowNewMom windowNewMom = new WindowNewMom();
                windowNewMom.ShowDialog();
                items.Add(windowNewMom.NewMom);
            });
        }
    }
}
using Castle.Windsor;
using Core.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApp
{
    public class MainWindowViewModel : BaseWindowViewModel, IMainWindowViewModel
    {
        public Observable<bool> IsSettingsOpen { get; set; }
        public RxAsyncCommand GoSettingsCommand { get; set; }


        public MainWindowViewModel(
            IWindsorContainer container, 
            IMainWindow window, 
            ISecurityChecker securityChecker
            /*, ISecurityFailedControlViewModel securityFailedControlViewModel*/
            ) : base(
                container, 
                window, 
                securityChecker
                /*, securityFailedControlViewModel*/
                )
        {
            IsSettingsOpen = new Observable<bool>(false);

            GoSettingsCommand = new RxAsyncCommand();

            GoSettingsCommand.Subscribe(x =>
            {
                //CurrentControlViewModel.Value = GetContent<ISettingsControlViewModel, ISettingsControl>(true);
                IsSettingsOpen.Value = !IsSettingsOpen.Value;
            });
        }

        
    }
}

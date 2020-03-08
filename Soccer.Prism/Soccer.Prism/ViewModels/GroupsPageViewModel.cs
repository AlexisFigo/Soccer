using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Soccer.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Soccer.Prism.ViewModels
{
    public class GroupsPageViewModel : ViewModelBase
    {
        private TournamentResponse _tournamen;
        public GroupsPageViewModel(INavigationService navigation):
            base(navigation)
        {
            Title = "Groups";
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            _tournamen = parameters.GetValue<TournamentResponse>("tournament");

            Title = _tournamen.Name;
        }
    }
}

using Prism.Commands;
using Prism.Navigation;
using Soccer.Common.Models;
using Soccer.Prism.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Soccer.Prism.ViewModels
{
    public class TournamentItemViewModel : TournamentResponse
    {
        private readonly INavigationService _navigationService;
        private DelegateCommand _selectTournamentCommand;

        public TournamentItemViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        public DelegateCommand SelectTournamentCommand => _selectTournamentCommand ??
            (_selectTournamentCommand = new DelegateCommand(SelectTournamentAsync));

        private async void SelectTournamentAsync()
        {
            var parameters = new NavigationParameters();
            parameters.Add("tournament", this);

            await _navigationService.NavigateAsync(nameof (GroupsPage),parameters);
        }
    }
}

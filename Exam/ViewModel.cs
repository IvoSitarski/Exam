using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Exam.Models;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using System.ComponentModel;
using System.Windows;

namespace Exam
{

    public class ViewModel : INotifyPropertyChanged
    {
        private PartyRequest pr;
        public PartyRequest Request
        {
            get { return pr; }
            set
            {
                pr = value;
                OnPropertyChanged(nameof(Request));
            }
        }

        private PartyContext context;

        public ICommand AddCommand { get; set; }
        public ICommand RemoveGuestCommand { get; set; }
        public ICommand ShowApprovedRequestsCommand { get; set; }

        public List<ApprovedRequest> ApprovedRequests => context.ApprovedRequests;

        public ViewModel()
        {
            context = new PartyContext();
            Request = new PartyRequest();
            AddCommand = new AddRequestCommand(this);
            RemoveGuestCommand = new RemoveGuestCommand(this);
            ShowApprovedRequestsCommand = new ShowApprovedRequestsCommand(this);
        }

        public void SaveRequestToDatabase(PartyRequest request)
        {
            var balloonHelper = new BalloonHelper(request.Baloons);
            request.RegularBalloons = balloonHelper.RegularBalloons;
            request.HeliumBalloons = balloonHelper.HeliumBalloons;

            context.AddRequest(request);
            context.SaveChanges();
        }

        public void ApproveRequest(PartyRequest request)
        {
            var approvedRequest = new ApprovedRequest
            {
                Applicant = request.Applicant,
                ApplicantPN = request.ApplicantPN,
                BirthdayPerson = request.BirthdayPerson,
                BirthdayPersonAge = request.BirthdayPersonAge,
                Birthday = request.Birthday,
                PartyDate = request.PartyDate,
                Baloons = request.Baloons,
                RegularBalloons = request.RegularBalloons,
                HeliumBalloons = request.HeliumBalloons,
                Guests = request.Guests.ToList()
            };

            context.ApproveRequest(approvedRequest);
            context.SaveChanges();
            OnPropertyChanged(nameof(ApprovedRequests));
        }

        public void RemoveGuestById(int guestId)
        {
            var guest = Request.Guests.FirstOrDefault(g => g.Id == guestId);
            if (guest != null)
            {
                Request.Guests.Remove(guest);
                OnPropertyChanged(nameof(Request.Guests));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }


}

using CoreTweet;
using System;
using System.Net;
using System.Net.Http;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SG2022.ViewModels
{
	public class AboutViewModel : BaseViewModel
	{
		public AboutViewModel()
		{
			Title = "About";
			OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
			TweetCommand = new Command(OnTweetClicked);
		}

		public ICommand OpenWebCommand { get; }
		public Command TweetCommand { get; }

		private void OnTweetClicked(object obj)
		{
		    string ConsumerKey = "";
		    string ConsumerSecret = "";
		    string AccessToken = "";
		    string AccessSecret = "";

            var session = OAuth.Authorize(ConsumerKey, ConsumerSecret);
            var client = new HttpClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            Tokens tokens = Tokens.Create(ConsumerKey, ConsumerSecret, AccessToken, AccessSecret);
            Status statusResult = tokens.Statuses.Update(new { status = "test tweet"});
		}
	}
}
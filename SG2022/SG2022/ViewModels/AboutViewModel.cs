using CoreTweet;
using System;
using System.ComponentModel;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
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
			TweetPinCommand = new Command(OnTweetPinClicked);
			Url = session.AuthorizeUri.AbsoluteUri;
		}

		public ICommand OpenWebCommand { get; }
		public Command TweetCommand { get; }
		public Command TweetPinCommand { get; }
		private WebViewSource url;
		public WebViewSource Url { get => url; set => SetProperty(ref url, value); }
		private string pinCode;
		public string PinCode { get => pinCode; set => SetProperty(ref pinCode, value); }

		//API key
		static string ConsumerKey = "";
		//API secret key
		static string ConsumerSecret = "";
		OAuth.OAuthSession session = OAuth.Authorize(ConsumerKey, ConsumerSecret);

		private void OnTweetPinClicked(object obj)
		{
			if (string.IsNullOrEmpty(PinCode)) return;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
			try
			{
				// トークン取得
				var browserTokens = OAuth.GetTokens(session, PinCode);
				Status statusResult = browserTokens.Statuses.Update(new { status = "test tweet by user" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss ffff") });
			}
			catch (Exception exception)
			{
			}
		}
	}
}
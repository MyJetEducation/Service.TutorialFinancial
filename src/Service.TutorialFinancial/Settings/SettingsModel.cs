using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.TutorialFinancial.Settings
{
	public class SettingsModel
	{
		[YamlProperty("TutorialFinancial.SeqServiceUrl")]
		public string SeqServiceUrl { get; set; }

		[YamlProperty("TutorialFinancial.ZipkinUrl")]
		public string ZipkinUrl { get; set; }

		[YamlProperty("TutorialFinancial.ElkLogs")]
		public LogElkSettings ElkLogs { get; set; }

		[YamlProperty("TutorialFinancial.EducationProgressServiceUrl")]
		public string EducationProgressServiceUrl { get; set; }

		[YamlProperty("TutorialFinancial.EducationRetryServiceUrl")]
		public string EducationRetryServiceUrl { get; set; }

		[YamlProperty("TutorialFinancial.UserRewardServiceUrl")]
		public string UserRewardServiceUrl { get; set; }

		[YamlProperty("TutorialFinancial.UserProgressServiceUrl")]
		public string UserProgressServiceUrl { get; set; }
	}
}
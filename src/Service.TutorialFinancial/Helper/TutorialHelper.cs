using Service.Education.Structure;

namespace Service.TutorialFinancial.Helper
{
	public static class TutorialHelper
	{
		public static readonly EducationTutorial Tutorial = EducationTutorial.FinancialServices;

		public static readonly EducationStructureTutorial StructureTutorial = EducationStructure.Tutorials[Tutorial];
	}
}
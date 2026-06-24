using Grammophone.Domos.Tests.Music.Cases;
using Grammophone.Domos.Tests.Music.DataAccess.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grammophone.Domos.Tests.Music.Cases.EntityFrameworkCore
{
	[TestClass]
	public class EFCoreMusicLogicTests : MusicLogicTestCases
	{
		protected override string ConfigurationSectionName => "musicLogic";

		protected override void ResetData()
		{
			EFCoreMusicTestFactory.DropDatabase();

			using (var innerContainer = EFCoreMusicTestFactory.CreateInnerContainer())
			{
				innerContainer.Database.EnsureCreated();

				using (var domainContainer = new EFCoreMusicDomosDomainContainerAdapter(innerContainer))
				{
					MusicTestDataSeeder.Seed(domainContainer);
				}
			}
		}
	}
}

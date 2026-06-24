using Grammophone.Domos.Tests.Music.DataAccess.EntityFrameworkCore;

namespace Grammophone.Domos.Tests.Music.Cases.EntityFrameworkCore
{
	public class EFCoreMusicTestDomainContainerAdapter : EFCoreMusicDomosDomainContainerAdapter
	{
		public EFCoreMusicTestDomainContainerAdapter()
			: base(EFCoreMusicTestFactory.CreateInnerContainer())
		{
		}
	}
}

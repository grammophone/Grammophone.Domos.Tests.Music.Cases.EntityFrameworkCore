using Grammophone.Domos.Tests.Music.DataAccess.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Grammophone.Domos.Tests.Music.Cases.EntityFrameworkCore
{
	internal static class EFCoreMusicTestFactory
	{
		public const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=GrammophoneDomosMusic_EFCore_Test;Integrated Security=True;TrustServerCertificate=True";

		public static EFCoreMusicDomosDomainContainer CreateInnerContainer()
		{
			var options = new DbContextOptionsBuilder<EFCoreMusicDomosDomainContainer>()
				.UseSqlServer(ConnectionString)
				.Options;

			return new EFCoreMusicDomosDomainContainer(options);
		}

		public static void DropDatabase()
		{
			using (var connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True"))
			{
				connection.Open();
				using (var command = connection.CreateCommand())
				{
					command.CommandText = "IF DB_ID(N'GrammophoneDomosMusic_EFCore_Test') IS NOT NULL BEGIN ALTER DATABASE [GrammophoneDomosMusic_EFCore_Test] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; DROP DATABASE [GrammophoneDomosMusic_EFCore_Test]; END";
					command.ExecuteNonQuery();
				}
			}
		}
	}
}

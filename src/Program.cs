using Stefandevo.Genyman.Logo.Implementation;
using Genyman.Core;

namespace Stefandevo.Genyman.Logo
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			GenymanApplication.Run<Configuration, NewTemplate, Generator>(args);
		}
	}
}
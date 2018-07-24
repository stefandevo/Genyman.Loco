using Genyman.Core;
using Stefandevo.Genyman.Loco.Implementation;

namespace Stefandevo.Genyman.Loco
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			GenymanApplication.Run<Configuration, NewTemplate, Generator>(args);
		}
	}
}
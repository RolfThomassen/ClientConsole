using System;
using ClientConsole.Net.SocketV2;
using Socket.Shared;

namespace ClientConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter Host Name: ");
			var hostName = Console.ReadLine();

			Console.Write("Enter Port Number: ");
			var portNumber = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Connecting...");

			var clientSocket = new ClientSocket(hostName, portNumber);

			try
			{
				clientSocket.Connect();
			}
			catch (POCSocketException pocEx)
			{
				Console.WriteLine(pocEx.Message);
			}
		}
	}
}
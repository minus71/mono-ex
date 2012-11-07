using System;
using System.IO.Ports;
public class HelloWorld{
	static public void Main (){
		Console.WriteLine ("Hello Mono World");
		// Get a list of serial port names. 
		string[] ports = SerialPort.GetPortNames();

		Console.WriteLine("The following serial ports were found:");

		// Display each port name to the console. 
		foreach(string port in ports){
			Console.WriteLine(port);
		}
	}
}

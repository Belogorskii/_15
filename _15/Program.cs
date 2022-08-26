/*Разработать интерфейс ISeries генерации ряда чисел. Интерфейс содержит следующие элементы:
метод void setStart(int x) - устанавливает начальное значение
метод int getNext() - возвращает следующее число ряда
метод void reset() - выполняет сброс к начальному значению
Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries. 
В классах реализовать методы интерфейса в соответствии с 
логикой арифметической и геометрической прогрессии соответственно.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _15
{
	class Program
	{
		public static void Main(string[] args)
		{
		}
	}
	interface ISeries
	{
		void SetStart(int x);
		int GetNext();
		void Reset();
	}
	class ArithProgression : ISeries
	{
		int difference = 3;
		int x = 0;
		SetStart(int x);

		public void SetStart() // устанавливает начальное значение
		{
			x = Convert.ToInt32(Console.ReadLine());
		}
		public int GetNext() //возвращает следующее число ряда
		{
			int secondNumber = x + difference;
			return secondNumber;
		}
		public void Reset(int secondNumber) //выполняет сброс к начальному значению
		{
			int firstNumber = secondNumber - difference;
		}
	}
	class GeomProgression : ISeries
	{
		int difference = 3;
		int x = 0;
		public void SetStart(int x) // устанавливает начальное значение
		{
			x = Convert.ToInt32(Console.ReadLine());
		}
		public int GetNext() //возвращает следующее число ряда
		{
			int secondNumber = x * difference;
			return secondNumber;
		}
		public void Reset() //выполняет сброс к начальному значению
		{
			int firstNumber = x / difference;
		}
	}
}
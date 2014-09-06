using System.Collections;
using System.IO;
/*using JsonFx.Json;
using JsonFx.Xml;
/// <summary>
/// Json fx adapter. Adapter for Json FX library
/// </summary>
public class JsonFxAdapter<T>
{
	
	public static void SaveXML(string path,T[] objects)
	{
		string str = JsonWriter.Serialize(objects);
		//Debug.Log(str.ToString());
		StreamWriter wr = new StreamWriter(path);
		wr.WriteLine(str);
		wr.Close();
	}
	public static T[] LoadXML(string path)
	{
		StreamReader reader = new StreamReader(path);
		 string text = reader.ReadToEnd();
		//Debug.Log(text);
		reader.Close();
		T[] arr1 = JsonReader.Deserialize<T[]>(text);
		return arr1;
	}
	
	public static void SaveJson(string path,T[] objects)
	{
		string str = JsonWriter.Serialize(objects);
		//Debug.Log(str.ToString());
		StreamWriter wr = new StreamWriter(path);
		wr.WriteLine(str);
		wr.Close();
	}
	public static T[] LoadJson(string path)
	{
		StreamReader reader = new StreamReader(path);
		 string text = reader.ReadToEnd();
		//Debug.Log(text);
		reader.Close();
		
		T[] arr1 = JsonReader.Deserialize<T[]>(text);
		return arr1;
	}
	public static T[] LoadJsonFromString(string json)
	{
		T[] arr1 = JsonReader.Deserialize<T[]>(json);
		return arr1;
	}
}
*/
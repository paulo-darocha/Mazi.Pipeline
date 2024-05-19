using Newtonsoft.Json.Linq;
using System;

namespace Mazi.Pipeline.JsonUtilities;

public class JsonEditor
{
   private readonly JObject _json;
   private readonly string _pathToFile;

   public JsonEditor(string pathToFile)
   {
      if (string.IsNullOrEmpty(pathToFile))
         throw new ArgumentException($"{nameof(pathToFile)} is null or empty.");

      _pathToFile = pathToFile;
      AssertFileExists(_pathToFile);
      _json = LoadJsonFromFile(_pathToFile);
   }

   public JsonEditor(string json, bool loadFromString)
   {
      if (loadFromString == false)
      {
         throw new InvalidOperationException(
            "Argument not valid on this constructor."
         );
      }
      if (string.IsNullOrEmpty(json))
         throw new ArgumentException(
            $"{nameof(json)} is null or empty.",
            nameof(json)
         );
      _pathToFile = null;
      _json = JObject.Parse(json);
   }

   public JsonEditor(JObject fromObject)
   {
      if (fromObject == null || fromObject.Count == 0)
      {
         throw new ArgumentException(
            $"{nameof(fromObject)} is null or empty.",
            nameof(fromObject)
         );
      }
      _json = fromObject;
   }

   public string GetValue(params string[] nodes)
   {
      if (nodes == null || nodes.Length == 0)
         throw new ArgumentException(
            $"{nameof(nodes)} is null or empty.",
            nameof(nodes)
         );
      var query = GetJsonQueryForNodes(nodes);
      return GetValueUsingQuery(query.ToString());
   }

   public void SetValue(string nodeValue, params string[] nodes)
   {
      throw new NotImplementedException();
   }

   public string ToJsonString()
   {
      throw new NotImplementedException();
   }

   public string GetSiblingValue(SiblingValueArguments args)
   {
      throw new NotImplementedException();
   }

   public void SetSiblingValue(SiblingValueArguments args)
   {
      throw new NotImplementedException();
   }

   public JToken GetNode(params string[] nodes)
   {
      throw new NotImplementedException();
   }

   public JToken GetNodeByQuery(string query)
   {
      throw new NotImplementedException();
   }

   private string GetJsonQueryForNodes(params string[] nodes)
   {
      throw new NotImplementedException();
   }

   // private ////////////////////////////////////////////
   // methods ////////////////////////////////////////////

   private void CreateNodeStructure(string[] nodes)
   {
      throw new NotImplementedException();
   }

   private void WriteJsonFile() { }

   private JToken GetJToken(JObject json, string query)
   {
      throw new NotImplementedException();
   }

   private string GetValueUsingQuery(string query)
   {
      throw new NotImplementedException();
   }

   private JObject LoadJsonFromFile(string pathToFile)
   {
      throw new NotImplementedException();
   }

   private void AssertFileExists(string pathToFile)
   {
      throw new NotImplementedException();
   }

   private JToken FindParentNodeBySiblingValue(SiblingValueArguments args)
   {
      throw new NotImplementedException();
   }
}

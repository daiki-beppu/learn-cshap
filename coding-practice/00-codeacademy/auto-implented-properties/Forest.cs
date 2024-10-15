/*
コード・エディターで、nameとtreeの基本的なフィールドとプロパティを定義しました。
現在のnameフィールドとNameプロパティを、自動実装されたNameプロパティで置き換えてください。

現在のツリーフィールドとツリープロパティを自動ツリープロパティに置き換える。
*/

using System;

namespace AutoImplementedProperties
{
  class Forest
  {
    public string Name
    { get; set; }

    public int Trees
    { get; set; }

    public int age;

    private string biome;
    public string Biome
    {
      get
      {
        return biome;
      }
      set
      {
        string[] validBiomes = { "Tropical", "Temperate", "Boreal" };
        if (Array.IndexOf(validBiomes, value) >= 0)
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }
  }

}

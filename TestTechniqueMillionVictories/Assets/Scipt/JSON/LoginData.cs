using System;

[Serializable]
public struct Data
{
    public ContenuData[] ContenuDatas;
}

[Serializable]
public struct ContenuData
{
    public int id;
    public string title;
    public string content;
}

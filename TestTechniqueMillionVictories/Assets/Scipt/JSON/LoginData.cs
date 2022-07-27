using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

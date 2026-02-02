namespace AuthServiceIN6BV.Application.Interfaces;

public interface IFileData
{
    byte[] Data {get;}
    string Content {get;}
    string FileName {get;}
    long Size {get;}
}
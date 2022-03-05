namespace FarPrototype.Events
{
    internal interface IUpdatable
    {
        void UpdateState(DirectoryInfo[] folders, FileInfo[] files);
    }
}

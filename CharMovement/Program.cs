using System.ComponentModel;

public class Location : INotifyPropertyChanged
{
    private int _xCoordinate;
    private int _yCoordinate;

    public int XCoordinate
    {
        get { return _xCoordinate; }
        set
        {
            _xCoordinate = value;
            OnPropertyChanged("XCoordinate");
        }
    }

    public int YCoordinate
    {
        get { return _yCoordinate; }
        set
        {
            _yCoordinate = value;
            OnPropertyChanged("YCoordinate");
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

public class GameSession : INotifyPropertyChanged
{
    private Location _currentLocation;
    private World _currentWorld;

    public Location CurrentLocation
    {
        get { return _currentLocation; }
        set
        {
            _currentLocation = value;
            OnPropertyChanged("CurrentLocation");
        }
    }

    public World CurrentWorld
    {
        get { return _currentWorld; }
        set
        {
            _currentWorld = value;
            OnPropertyChanged("CurrentWorld");
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public void MoveNorth()
    {
        CurrentLocation = new Location { XCoordinate = CurrentLocation.XCoordinate, YCoordinate = CurrentLocation.YCoordinate + 1 };
    }

    public void MoveWest()
    {
        CurrentLocation = new Location { XCoordinate = CurrentLocation.XCoordinate - 1, YCoordinate = CurrentLocation.YCoordinate };
    }

    public void MoveEast()
    {
        CurrentLocation = new Location { XCoordinate = CurrentLocation.XCoordinate + 1, YCoordinate = CurrentLocation.YCoordinate };
    }

    public void MoveSouth()
    {
        CurrentLocation = new Location { XCoordinate = CurrentLocation.XCoordinate, YCoordinate = CurrentLocation.YCoordinate - 1 };
    }
}

public class GameSession : INotifyPropertyChanged
{

    public void Dodge()
    {


    }

    public void Parry()
    {


    }

    // ... (existing code)
}




public static void Main(string[] args){
	Server s = new Server("http://127.0.0.1:8060", "admin", "admin" );
	s.UserWebNewsGetAll();
	s.AdminMetaResourceNew("here is a lovely string");
}

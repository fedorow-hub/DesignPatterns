

var builder = WebApplication.CreateBuilder(args);

// ��������� ������� ��� ������ � gRPC
builder.Services.AddGrpc();

var app = builder.Build();

// ����������� ��������� HTTP-��������
app.MapGrpcService<GreeterService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client...");

app.Run();

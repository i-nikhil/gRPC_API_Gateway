using grpc.client.Services;
using Grpc.Net.Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton(_ =>
{
    string channelUrl = "http://127.0.0.1:5255";
    int maxSendMesssageSize = 2 * 1024 * 1024; // 2MB
    int maxReceivedMessageSize = 5 * 1024 * 1024; // 5MB

    GrpcChannel channel = GrpcChannel.ForAddress(channelUrl, new GrpcChannelOptions
    {
        MaxSendMessageSize = maxSendMesssageSize,
        MaxReceiveMessageSize = maxReceivedMessageSize
    });

    return channel;
});

builder.Services.AddScoped<IPersonService, PersonService>();
builder.Services.AddHttpContextAccessor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

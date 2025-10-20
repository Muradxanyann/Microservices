using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using MMLib.SwaggerForOcelot;

var builder = WebApplication.CreateBuilder(args);

// 1. Загружаем конфигурацию Ocelot из файла configuration.json
builder.Configuration.AddJsonFile("configuration.json", optional: false, reloadOnChange: true);

// 2. Добавляем сервисы Ocelot в DI контейнер
builder.Services.AddOcelot(builder.Configuration);

// 3. Добавляем поддержку Swagger для Ocelot
// Эта библиотека соберет Swagger JSON файлы с нижестоящих сервисов
// и представит их как единый UI.
builder.Services.AddSwaggerForOcelot(builder.Configuration);

// 4. Добавляем стандартные сервисы Web API
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


var app = builder.Build();

// 5. Настраиваем пайплайн для Swagger UI
app.UseSwagger();
// Используем UI от SwaggerForOcelot
app.UseSwaggerForOcelotUI(opt => {
    opt.PathToSwaggerGenerator = "/swagger/docs";
}).UseOcelot().Wait();


app.MapControllers();

app.Run();
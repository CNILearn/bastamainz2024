# BASTA! Mainz 2024

* Be ready for C# 12 and C# 13
* Logs, metrics, distributed tracing and OpenTelemetry

## Be ready for C# 12 and C# 13

Dienstag, 17.9.2024, 10:45 - 11:45, Gutenbergsaal 4

C# 12 ist releast, die nächste Version von C# steht bereits vor der Tür. Mit Primary Constructors und Collection Expressions kann der Code in allen .NET-Applikationen vereinfacht werden. Was dahinter steckt, was es sonst noch neues in C# gibt, was mit Inline Arrays und Interceptors gemacht werden kann, und was in C# 13 kommt, wie z. B. Erweiterungen bei Collection Expressions und ref struct-Typen, den neuen Extensions, und dem lock Keyword basierend auf der .NET-9-Lock-Klasse lernen Sie in dieser Session.

[C# Slides](slides/CSharp.pdf)

### C# Samples

- Escape sequence
- Minimal API
- Alias any type
- Primary constructors
- Ref readonly
- allows ref struct
- Params
- Inline arrays
- Collection literals
- Optional parameters in lambda expressions
- Unsafe accessor
- Interceptors
- Native AOT

## Logs, metrics, distributed tracing, and OpenTelemetry

Donnerstag, 19.9.2024, 12:00 - 13:00, Gutenbergsaal 1

Grafana? Prometheus? Application Insights? OpenTelemetry? Am Beispiel einer verteilten Lösung die sowohl on Premises als auch mit Azure Cloud Services läuft, sehen Sie wie Log, Metrics, und Distributed Tracing mit .NET-Applikationen implementiert werden können, und diese Daten mit Grafana und Prometheus sowie mit Azure Services wie Azure Monitor, Log Analytics und Application Insights ausgewertet werden kann.

[Slides](slides/telemetry.pdf)

### Samples

- Logging
- Metrics
- Distributed Tracing

#### Codebreaker

For **logging**, see the `GamesApi` project, the `Infrastructure\Log` class for source-generated logging. The `GamesService` class injects the ILogger interface, and writes log messages.

For **metrics**, see the `Infrastructure\GamesMetrics` class uses instruments to write counts. The `ApplicationServices` class configures the dependency injection container to configure metrics. The `GamesService` class writes metrics (`GameStarted`, `MoveSet`, `GameEnded`).

For **distributed tracing**, the `ActivitySource` is registered as a keyed service in `ApplicationServices`, and injected in the `GamesService` class. Activities are started using tags, and the status is set.

- [Pragmatic Microservices with C# and Azure - the book](https://www.packtpub.com/en-us/product/pragmatic-microservices-with-c-and-azure-9781835088296)
- [Pragmatic Microservices with C# and Azure - source code](https://github.com/PacktPublishing/Pragmatic-Microservices-with-CSharp-and-Azure)
- [More Codebreaker repos](https://github.com/codebreakerapp)
- [Blazor client app](https://blazor.codebreaker.app)

## Important Links

- [My blog](https://csharp.christiannagel.com)
- [CN innovation](https://www.cninnovation.com)

public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    // Otras configuraciones...

    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }
    else
    {
        app.UseExceptionHandler("/Home/Error");
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles(); // Esta línea es esencial para servir archivos estáticos desde la carpeta wwwroot

    // Otras configuraciones...
}

using PAA_2022_EF_Intro.Models;

Console.WriteLine("Ejemplos de utilización de LinQ para BD:");

using (EFContext bd = new EFContext())

{
    /* 1) Seleccionar todos los albumes */
    // SELECT * FROM Album; 

    /* var todosAlbumes = bd.Albumes.ToList(); 

     foreach (var album in todosAlbumes)
     {
         Console.WriteLine(album.Titulo);
     } 

     /* 2) Seleccionar los albumes de la productora "Blast! Musik! */
    // SELECT * FROM Album WHERE Productora =  'Blast! Musik!';

    /* var albumesProductora = bd.Albumes
       .Where(x => x.Productora == "Blast! Musik!")
       .ToList(); 
    Console.WriteLine(albumesProductora); */

    /* 3) Seleccionar todos los albumes de la productora "Blast! Musik!"
     * cuyo titulo sea "The Mente-Catos"
     */
    // SELECT * FROM Albumes WHERE Titulo = 'The Mente-Catos' 
    // AND Productora = 'Blast! Musik!';

    /* var albumProductoraTitulo = bd.Albumes
     .Where(x => x.Titulo == "The Mente - Catos" && x.Productora == "Blast! Musik!")
      .First();
    Console.WriteLine(albumProductoraTitulo);

    4) // Agregación: Max, Min, Count o Avg
    /* Obtener el total de albumes registrados */
    // SELECT * FROM (Titulo) FROM Album; 
    /* int total = bd.Albumes.Count();
    Console.WriteLine(total);

    /* 5) Obtener el ID mayor de canciones */
    // SELECT MAX(Id) FROM Cancion;
    /* int max = bd.Canciones.Max(x => x.Id);
    Console.WriteLine(max);

    /* 6) Obtener el ID menor de canciones */
    //SELECT MIN(Id) FROM Cancion;
    /* int min = bd.Canciones.Min(x => x.Id);
    Console.WriteLine(min);

    /* 7) Obtener el promedio de duración de canciones */
    // SELECT AVG(Duracion) FROM Cancion
    /* double promedioDuracion = bd.Canciones.Average(x => x.Duracion);
    Console.WriteLine(promedioDuracion.ToString());

    /* 8) Obtener los albumes cuyos Ids esten entre 3 y 4 ,
     * ordenador por Id de forma descendente
     */
    // SELECT * FROM album WHERE Id => 3 AND Id <= 4
    // ORDER BY Id DESC;
    /* var albumesOrdenados = bd.Albumes
        .Where(x => x.Id >= 3 && x.Id <= 4)
        .OrderByDescending(x => x.Id) 
        .ToList(); */

    /* 9) Obtener un solo album a través de su ID (3) */
    // SELECT * FROM Album WHERE Id = 3;
    // var album = bd.Albumes.Where(x => x.Id == 3).First();
    //var album = bd.Albumes.FirstOrDefault(x => x.Id == 3);

    /* 10) Actualizar el titulo del album "Perdonala a "Perdonala (Remix)"
     * a traves de la busqueda de su Id */
    // UPDATE Album SET Titulo = ' Perdonala (Remix)' WHERE Id = 3;
    /*  var albumEditar = bd.Albumes.FirstOrDefault(x => x.Id == 3);

     albumEditar.Titulo = "Perdonala (Remix 4)";
     bd.Albumes.Update(albumEditar);
     bd.SaveChanges(); 


     /* Insertar un nuevo album, sin un ID existente aun, que posea las siguientes caracteristicas 
      Nombre: "Al Pachak", Lanzamiento: El 20 de julio del 2022,
     No se poseen datos sobre su TopSeller.
     Productora: "Mastropiero que nunca"
     */
    //INSERT INTO Album(Titulo, Lanzamiento, TopSeller, Productora)
    // VALUES("Al Pachak", "2022-07-20", Null, "Mastropiero que nunca");


    /* Album nuevoAlbum = new Album()
     {
         Id = 4,
         Titulo = "Al Pachak",
         Lanzamiento = Convert.ToDateTime("2022-07-20"),
         TopSeller = null,
         Productora = "Mastropiero que nunca"
     };

     bd.Albumes.Add(nuevoAlbum);
     bd.SaveChanges(); */

    /* 12) Eliminar la cancion "Configurable 4th generation time-frame"
     a traves de la busqueda de su ID (6) */

    /* var cancionesEliminar = bd.Canciones.FirstOrDefault(x => x.Id == 6);
    bd.Canciones.Remove(cancionesEliminar);
    bd.SaveChanges();
    Console.WriteLine(cancionesEliminar); */










}
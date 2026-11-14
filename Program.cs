
using System;
using Microsoft.Data.Sqlite;

string conexion = "Data Source=videojuegos.db";

using (SqliteConnection db = new SqliteConnection(conexion))
{
    db.Open();

    string crearTabla = @"
        CREATE TABLE IF NOT EXISTS Videojuegos (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Nombre TEXT NOT NULL,
            Genero TEXT NOT NULL,
            Anio INTEGER NOT NULL
        );
    ";

    using (SqliteCommand comando = new SqliteCommand(crearTabla, db))
    {
        comando.ExecuteNonQuery();
    }

    string insertar = @"
        INSERT INTO Videojuegos (Nombre, Genero, Anio)
        VALUES (@nombre, @genero, @anio);
    ";

    string[,] videojuegos =
    {
        { "Minecraft", "Supervivencia", "2011" },
        { "Grand Theft Auto V", "Accion", "2013" },
        { "God of War", "Aventura", "2018" }
    };

    using (SqliteCommand contar = new SqliteCommand(
        "SELECT COUNT(*) FROM Videojuegos", db))
    {
        long cantidad = (long)contar.ExecuteScalar()!;

        if (cantidad == 0)
        {
            for (int i = 0; i < videojuegos.GetLength(0); i++)
            {
                using (SqliteCommand comando = new SqliteCommand(insertar, db))
                {
                    comando.Parameters.AddWithValue("@nombre", videojuegos[i, 0]);
                    comando.Parameters.AddWithValue("@genero", videojuegos[i, 1]);
                    comando.Parameters.AddWithValue("@anio", int.Parse(videojuegos[i, 2]));

                    comando.ExecuteNonQuery();
                }
            }

            Console.WriteLine("Se insertaron 3 videojuegos correctamente.");
        }
        else
        {
            Console.WriteLine("Los videojuegos ya están almacenados.");
        }
    }

    Console.WriteLine("\n===== REGISTRO DE VIDEOJUEGOS =====\n");

    string consultar = "SELECT Id, Nombre, Genero, Anio FROM Videojuegos";

    using (SqliteCommand comando = new SqliteCommand(consultar, db))
    using (SqliteDataReader lector = comando.ExecuteReader())
    {
        while (lector.Read())
        {
            Console.WriteLine($"ID: {lector.GetInt32(0)}");
            Console.WriteLine($"Nombre: {lector.GetString(1)}");
            Console.WriteLine($"Género: {lector.GetString(2)}");
            Console.WriteLine($"Año: {lector.GetInt32(3)}");
            Console.WriteLine("-----------------------------");
        }
    }
}

Console.WriteLine("\nConsulta finalizada correctamente.");

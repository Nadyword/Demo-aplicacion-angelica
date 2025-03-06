namespace HitoriaClinica.DataBase;

internal class Delete : Connection
{
    public static void DeleteClient(int id)
    {
        ExecuteNonQuery($"DELETE FROM clientes WHERE id = {id}");
    }

    public static void DeleteExamenFisico(int id)
    {
        ExecuteNonQuery($"DELETE FROM examen_fisico WHERE cliente_id = {id}");
    }

    public static void DeleteHabitosPsicobio(int id)
    {
        ExecuteNonQuery($"DELETE FROM habitos_psicobio WHERE cliente_id = {id}");
    }

    public static void DeleteHistorialTratamiento(int id)
    {
        ExecuteNonQuery($"DELETE FROM historial_tratamiento WHERE cliente_id = {id}");
    }

    public static void DeleteTratamientos(int id)
    {
        ExecuteNonQuery($"DELETE FROM tratamientos WHERE cliente_id = {id}");
    }

    public static void DeleteAntecedentesPersonales(int id)
    {
        ExecuteNonQuery($"DELETE FROM antecedentes_personales WHERE cliente_id = {id}");
    }

    public static void DeleteTratamientosCombo(int id)
    {
        ExecuteNonQuery($"DELETE FROM tratamientos_combo WHERE id = {id}");
    }
}

using System;
using System.Collections.Generic;
using System.Threading;

namespace ProyectoMatricula
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=====================================================================================================");
                Console.WriteLine("Matrícula Escolar - Menú Principal");
                Console.WriteLine("1. Registrar Estudiante");
                Console.WriteLine("2. Mostrar Resumen de Matrícula");
                Console.WriteLine("3. Editar Matrícula");
                Console.WriteLine("4. Borrar Matrícula");
                Console.WriteLine("5. Salir");   
                Console.WriteLine("=====================================================================================================");
                Console.WriteLine("Seleccione una opción: ");
                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.Clear();
                    Student student = new Student();

                    Console.WriteLine("Recolección de Datos de Entrada");
                    Thread.Sleep(1000); // Espera 1 segundos
                    Console.Write("Primer Nombre: ");
                    student.FirstName = Console.ReadLine();
                    Console.Write("Segundo Nombre: ");
                    student.MiddleName = Console.ReadLine();
                    Console.Write("Apellido Paterno: ");
                    student.LastName = Console.ReadLine();
                    Console.Write("Apellido Materno: ");
                    student.SecondLastName = Console.ReadLine();
                    Console.Write("Fecha de Nacimiento (yyyy-mm-dd): ");
                    student.BirthDate = DateTime.Parse(Console.ReadLine());
                    Console.Write("Lugar de Nacimiento: ");
                    student.BirthPlace = Console.ReadLine();
                    Console.Write("Género: ");
                    student.Gender = Console.ReadLine();
                    Console.Write("Nacionalidad: ");
                    student.Nationality = Console.ReadLine();
                    Console.Write("Número de Identificación (Cédula o DIMEX): ");
                    student.IdentificationNumber = Console.ReadLine();
                    Console.Write("Dirección: ");
                    student.Address = Console.ReadLine();
                    Console.Write("Número de Teléfono: ");
                    student.PhoneNumber = Console.ReadLine();
                    Console.Write("Correo Electrónico: ");
                    student.Email = Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine("=====================================================================================================");
                    Console.WriteLine();

                    Console.WriteLine("Compra del Formulario");
                    Thread.Sleep(1000); // Espera 1 segundos
                    Console.WriteLine("Realizar Consignación o Transferencia a la cuenta N° 21500004042 del Banco Promerica a nombre de Comunidad hijas de María Auxiliadora.");
                    Console.WriteLine("Enviar comprobante de pago al correo admisiones@mauxicentral.edu.co con los siguientes datos:");
                    Console.WriteLine("Nombre completo de la persona que lo compra, Número de Cédula, Dirección, Número de Celular, Correo Electrónico.");
                    Console.WriteLine("Esperando confirmación de recepción del formulario...");
                    Thread.Sleep(2000); // Espera 2 segundos

                    // Simulamos la recepción del formulario
                    Console.WriteLine("Formulario recibido. Documentos requeridos enviados al correo.");
                    Thread.Sleep(1000); // Espera 1 segundos

                    Console.WriteLine();
                    Console.WriteLine("=====================================================================================================");
                    Console.WriteLine();

                    Console.WriteLine("Diligenciar Formulario y Reunir Documentos:");
                    Thread.Sleep(1000); // Espera 2 segundos
                    Console.WriteLine("Formulario Diligenciado, Hoja de Procedencia, Paz y Salvo, Registro Civil, Fotocopias, Certificados.");

                    Console.WriteLine();
                    Console.WriteLine("=====================================================================================================");
                    Console.WriteLine();

                    Console.WriteLine("Información Académica");
                    Console.Write("Grado o Curso al que se matricula: ");
                    student.Grade = Console.ReadLine();
                    Console.Write("Escuela Anterior: ");
                    student.PreviousSchool = Console.ReadLine();
                    Console.Write("Historial Académico: ");
                    student.AcademicHistory = Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine("=====================================================================================================");
                    Console.WriteLine();

                    Console.WriteLine("Información Familiar");
                    Thread.Sleep(1000); // Espera 1 segundos
                    Console.Write("Nombre Completo del Padre/Madre o Tutor: ");
                    student.GuardianName = Console.ReadLine();
                    Console.Write("Número de Identificación del Padre/Madre o Tutor: ");
                    student.GuardianId = Console.ReadLine();
                    Console.Write("Dirección de Residencia del Padre/Madre o Tutor: ");
                    student.GuardianAddress = Console.ReadLine();
                    Console.Write("Número de Teléfono del Padre/Madre o Tutor: ");
                    student.GuardianPhoneNumber = Console.ReadLine();
                    Console.Write("Correo Electrónico del Padre/Madre o Tutor: ");
                    student.GuardianEmail = Console.ReadLine();
                    Console.Write("Ocupación del Padre/Madre o Tutor: ");
                    student.GuardianOccupation = Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine("=====================================================================================================");
                    Console.WriteLine();

                    Console.WriteLine("Información Médica");
                    Thread.Sleep(1000); // Espera 1 segundos
                    Console.Write("Estado de Salud: ");
                    student.HealthStatus = Console.ReadLine();
                    Console.Write("Seguro Médico: ");
                    student.MedicalInsurance = Console.ReadLine();
                    Console.Write("Contacto de Emergencia (Nombre): ");
                    student.EmergencyContactName = Console.ReadLine();
                    Console.Write("Contacto de Emergencia (Relación): ");
                    student.EmergencyContactRelationship = Console.ReadLine();
                    Console.Write("Contacto de Emergencia (Teléfono): ");
                    student.EmergencyContactPhoneNumber = Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine("=====================================================================================================");
                    Console.WriteLine();

                    Console.WriteLine("Seleccione Materias (ingrese 'fin' para terminar):");
                    while (true)
                    {
                        string subject = Console.ReadLine();
                        if (subject.ToLower() == "fin")
                        {
                            break;
                        }
                        if (!string.IsNullOrWhiteSpace(subject)) // Verifica si la entrada no está vacía
                        {
                            student.Subjects.Add(subject);
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("=====================================================================================================");
                    Console.WriteLine();

                    Console.WriteLine("Enviar Documentos al Dpto. de Admisiones");
                    Thread.Sleep(1000); // Espera 1 segundos
                    Console.WriteLine("Recibir Información sobre la Entrevista");
                    Thread.Sleep(1000); // Espera 1 segundos
                    Console.WriteLine("Fecha y Hora de la Entrevista");
                    Thread.Sleep(1000); // Espera 1 segundos

                    Console.WriteLine();
                    Console.WriteLine("=====================================================================================================");
                    Console.WriteLine();

                    Console.WriteLine("Asistir a la Entrevista y Aplicar Pruebas");
                    Thread.Sleep(1000); // Espera 1 segundos
                    Console.WriteLine("Generar Resumen de Matrícula");
                    students.Add(student);
                    Console.WriteLine();
                    Console.WriteLine("=====================================================================================================");
                    Console.WriteLine();
                    Console.WriteLine("Estudiante registrado exitosamente");
                    Console.WriteLine("(Presione 'Enter' para continuar)");
                    Console.ReadLine();
                }
                else if (option == 2)
                {
                    Console.Clear();
                    if (students.Count == 0)
                    {
                        Console.WriteLine("No hay matrículas registradas.");
                        Console.WriteLine("(Presione 'Enter' para continuar)");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Resumen de Matrícula:");
                        Console.WriteLine();
                        foreach (Student student in students)
                        {
                            Console.WriteLine("=====================================================================================================");
                            Console.WriteLine($"Nombre: {student.FirstName} {student.MiddleName} {student.LastName} {student.SecondLastName}");
                            Console.WriteLine($"Fecha de Nacimiento: {student.BirthDate.ToShortDateString()}");
                            Console.WriteLine($"Lugar de Nacimiento: {student.BirthPlace}");
                            Console.WriteLine($"Género: {student.Gender}");
                            Console.WriteLine($"Nacionalidad: {student.Nationality}");
                            Console.WriteLine($"Número de Identificación: {student.IdentificationNumber}");
                            Console.WriteLine($"Dirección: {student.Address}");
                            Console.WriteLine($"Teléfono: {student.PhoneNumber}");
                            Console.WriteLine($"Correo Electrónico: {student.Email}");
                            Console.WriteLine($"Grado: {student.Grade}");
                            Console.WriteLine($"Escuela Anterior: {student.PreviousSchool}");
                            Console.WriteLine($"Historial Académico: {student.AcademicHistory}");
                            Console.WriteLine($"Tutor: {student.GuardianName} - ID: {student.GuardianId}");
                            Console.WriteLine($"Dirección del Tutor: {student.GuardianAddress}");
                            Console.WriteLine($"Teléfono del Tutor: {student.GuardianPhoneNumber}");
                            Console.WriteLine($"Correo del Tutor: {student.GuardianEmail}");
                            Console.WriteLine($"Ocupación del Tutor: {student.GuardianOccupation}");
                            Console.WriteLine($"Estado de Salud: {student.HealthStatus}");
                            Console.WriteLine($"Seguro Médico: {student.MedicalInsurance}");
                            Console.WriteLine($"Contacto de Emergencia: {student.EmergencyContactName} - Relación: {student.EmergencyContactRelationship}");
                            Console.WriteLine($"Teléfono del Contacto de Emergencia: {student.EmergencyContactPhoneNumber}");
                            Console.WriteLine("Materias: " + (student.Subjects.Count > 0 ? string.Join(", ", student.Subjects) : "No hay materias registradas"));
                            Console.WriteLine($"Costo Total de la Matrícula: ${student.CalculateTotalCost():0.00}");
                            Console.WriteLine("=====================================================================================================");
                            Console.WriteLine("(Presione 'Enter' para continuar)");
                            Console.ReadLine();
                        }
                    }
                }
                else if (option == 3) // Editar Estudiante
                {
                    Console.Clear();
                    if (students.Count == 0)
                    {
                        Console.WriteLine("No hay matrículas registradas.");
                        Console.WriteLine("(Presione 'Enter' para continuar)");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Editar Estudiante:");
                        Console.WriteLine();
                        foreach (Student student in students)
                        {
                            Console.WriteLine($"{students.IndexOf(student) + 1}. {student.FirstName} {student.LastName}");
                        }
                        Console.Write("Seleccione el número del estudiante que desea editar (0 para cancelar): ");
                        int editChoice = int.Parse(Console.ReadLine());

                        if (editChoice > 0 && editChoice <= students.Count)
                        {
                            Student studentToEdit = students[editChoice - 1];

                            // Mostrar datos actuales del estudiante
                            Console.WriteLine("Datos Actuales del Estudiante:");
                            Console.WriteLine($"1. Primer Nombre: {studentToEdit.FirstName}");
                            Console.WriteLine($"2. Segundo Nombre: {studentToEdit.MiddleName}");
                            Console.WriteLine($"3. Apellido Paterno: {studentToEdit.LastName}");
                            Console.WriteLine($"4. Apellido Materno: {studentToEdit.SecondLastName}");
                            Console.WriteLine($"5. Fecha de Nacimiento: {studentToEdit.BirthDate.ToShortDateString()}");
                            Console.WriteLine($"6. Lugar de Nacimiento: {studentToEdit.BirthPlace}");
                            Console.WriteLine($"7. Género: {studentToEdit.Gender}");
                            Console.WriteLine($"8. Nacionalidad: {studentToEdit.Nationality}");
                            Console.WriteLine($"9. Número de Identificación: {studentToEdit.IdentificationNumber}");
                            Console.WriteLine($"10. Dirección: {studentToEdit.Address}");
                            Console.WriteLine($"11. Número de Teléfono: {studentToEdit.PhoneNumber}");
                            Console.WriteLine($"12. Correo Electrónico: {studentToEdit.Email}");
                            Console.WriteLine($"13. Grado: {studentToEdit.Grade}");
                            Console.WriteLine($"14. Escuela Anterior: {studentToEdit.PreviousSchool}");
                            Console.WriteLine($"15. Historial Académico: {studentToEdit.AcademicHistory}");
                            Console.WriteLine($"16. Nombre del Tutor: {studentToEdit.GuardianName}");
                            Console.WriteLine($"17. ID del Tutor: {studentToEdit.GuardianId}");
                            Console.WriteLine($"18. Dirección del Tutor: {studentToEdit.GuardianAddress}");
                            Console.WriteLine($"19. Teléfono del Tutor: {studentToEdit.GuardianPhoneNumber}");
                            Console.WriteLine($"20. Correo del Tutor: {studentToEdit.GuardianEmail}");
                            Console.WriteLine($"21. Ocupación del Tutor: {studentToEdit.GuardianOccupation}");
                            Console.WriteLine($"22. Estado de Salud: {studentToEdit.HealthStatus}");
                            Console.WriteLine($"23. Seguro Médico: {studentToEdit.MedicalInsurance}");
                            Console.WriteLine($"24. Contacto de Emergencia: {studentToEdit.EmergencyContactName}");
                            Console.WriteLine($"25. Relación con Contacto de Emergencia: {studentToEdit.EmergencyContactRelationship}");
                            Console.WriteLine($"26. Teléfono del Contacto de Emergencia: {studentToEdit.EmergencyContactPhoneNumber}");

                            Console.WriteLine();
                            Console.WriteLine("Ingrese el número del campo que desea editar (0 para terminar): ");
                            int fieldChoice = int.Parse(Console.ReadLine());

                            while (fieldChoice != 0)
                            {
                                switch (fieldChoice)
                                {
                                    case 1:
                                        Console.Write("Nuevo Primer Nombre: ");
                                        studentToEdit.FirstName = Console.ReadLine();
                                        break;
                                    case 2:
                                        Console.Write("Nuevo Segundo Nombre: ");
                                        studentToEdit.MiddleName = Console.ReadLine();
                                        break;
                                    case 3:
                                        Console.Write("Nuevo Apellido Paterno: ");
                                        studentToEdit.LastName = Console.ReadLine();
                                        break;
                                    case 4:
                                        Console.Write("Nuevo Apellido Materno: ");
                                        studentToEdit.SecondLastName = Console.ReadLine();
                                        break;
                                    case 5:
                                        Console.Write("Nueva Fecha de Nacimiento (yyyy-mm-dd): ");
                                        studentToEdit.BirthDate = DateTime.Parse(Console.ReadLine());
                                        break;
                                    case 6:
                                        Console.Write("Nuevo Lugar de Nacimiento: ");
                                        studentToEdit.BirthPlace = Console.ReadLine();
                                        break;
                                    case 7:
                                        Console.Write("Nuevo Género: ");
                                        studentToEdit.Gender = Console.ReadLine();
                                        break;
                                    case 8:
                                        Console.Write("Nueva Nacionalidad: ");
                                        studentToEdit.Nationality = Console.ReadLine();
                                        break;
                                    case 9:
                                        Console.Write("Nuevo Número de Identificación: ");
                                        studentToEdit.IdentificationNumber = Console.ReadLine();
                                        break;
                                    case 10:
                                        Console.Write("Nueva Dirección: ");
                                        studentToEdit.Address = Console.ReadLine();
                                        break;
                                    case 11:
                                        Console.Write("Nuevo Número de Teléfono: ");
                                        studentToEdit.PhoneNumber = Console.ReadLine();
                                        break;
                                    case 12:
                                        Console.Write("Nuevo Correo Electrónico: ");
                                        studentToEdit.Email = Console.ReadLine();
                                        break;
                                    case 13:
                                        Console.Write("Nuevo Grado: ");
                                        studentToEdit.Grade = Console.ReadLine();
                                        break;
                                    case 14:
                                        Console.Write("Nueva Escuela Anterior: ");
                                        studentToEdit.PreviousSchool = Console.ReadLine();
                                        break;
                                    case 15:
                                        Console.Write("Nuevo Historial Académico: ");
                                        studentToEdit.AcademicHistory = Console.ReadLine();
                                        break;
                                    case 16:
                                        Console.Write("Nuevo Nombre del Tutor: ");
                                        studentToEdit.GuardianName = Console.ReadLine();
                                        break;
                                    case 17:
                                        Console.Write("Nuevo ID del Tutor: ");
                                        studentToEdit.GuardianId = Console.ReadLine();
                                        break;
                                    case 18:
                                        Console.Write("Nueva Dirección del Tutor: ");
                                        studentToEdit.GuardianAddress = Console.ReadLine();
                                        break;
                                    case 19:
                                        Console.Write("Nuevo Teléfono del Tutor: ");
                                        studentToEdit.GuardianPhoneNumber = Console.ReadLine();
                                        break;
                                    case 20:
                                        Console.Write("Nuevo Correo del Tutor: ");
                                        studentToEdit.GuardianEmail = Console.ReadLine();
                                        break;
                                    case 21:
                                        Console.Write("Nueva Ocupación del Tutor: ");
                                        studentToEdit.GuardianOccupation = Console.ReadLine();
                                        break;
                                    case 22:
                                        Console.Write("Nuevo Estado de Salud: ");
                                        studentToEdit.HealthStatus = Console.ReadLine();
                                        break;
                                    case 23:
                                        Console.Write("Nuevo Seguro Médico: ");
                                        studentToEdit.MedicalInsurance = Console.ReadLine();
                                        break;
                                    case 24:
                                        Console.Write("Nuevo Nombre del Contacto de Emergencia: ");
                                        studentToEdit.EmergencyContactName = Console.ReadLine();
                                        break;
                                    case 25:
                                        Console.Write("Nueva Relación con el Contacto de Emergencia: ");
                                        studentToEdit.EmergencyContactRelationship = Console.ReadLine();
                                        break;
                                    case 26:
                                        Console.Write("Nuevo Teléfono del Contacto de Emergencia: ");
                                        studentToEdit.EmergencyContactPhoneNumber = Console.ReadLine();
                                        break;
                                    default:
                                        Console.WriteLine("Opción inválida.");
                                        break;
                                }

                                Console.WriteLine();
                                Console.WriteLine("Ingrese el número del campo que desea editar (0 para terminar): ");
                                fieldChoice = int.Parse(Console.ReadLine());
                            }

                            // Mostrar confirmación y aplicar cambios
                            Console.Write("¿Desea guardar los cambios realizados? (S/N): ");
                            string confirmEdit = Console.ReadLine();
                            if (confirmEdit.ToUpper() == "S")
                            {
                                Console.WriteLine("Estudiante editado exitosamente.");
                                Console.WriteLine("(Presione 'Enter' para continuar)");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Edición cancelada.");
                                Console.WriteLine("(Presione 'Enter' para continuar)");
                                Console.ReadLine();
                            }
                        }
                        else if (editChoice == 0)
                        {
                            // Cancelar operación de edición
                            Console.WriteLine("Operación cancelada.");
                            Console.WriteLine("(Presione 'Enter' para continuar)");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Opción inválida.");
                            Console.WriteLine("(Presione 'Enter' para continuar)");
                            Console.ReadLine();
                        }
                    }
                }

                else if (option == 4) // Borrar Estudiante
                {
                    Console.Clear();
                    if (students.Count == 0)
                    {
                        Console.WriteLine("No hay matrículas registradas.");
                        Console.WriteLine("(Presione 'Enter' para continuar)");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Borrar Estudiante:");
                        Console.WriteLine();
                        foreach (Student student in students)
                        {
                            Console.WriteLine($"{students.IndexOf(student) + 1}. {student.FirstName} {student.LastName}");
                        }
                        Console.Write("Seleccione el número del estudiante que desea borrar (0 para cancelar): ");
                        int deleteChoice = int.Parse(Console.ReadLine());

                        if (deleteChoice > 0 && deleteChoice <= students.Count)
                        {
                            Student studentToDelete = students[deleteChoice - 1];

                            // Confirmación de borrado
                            Console.Write($"¿Está seguro de que desea borrar a {studentToDelete.FirstName} {studentToDelete.LastName}? (S/N): ");
                            string confirmDelete = Console.ReadLine();

                            if (confirmDelete.ToUpper() == "S")
                            {
                                students.Remove(studentToDelete);
                                Console.WriteLine("Estudiante borrado exitosamente.");
                                Console.WriteLine("(Presione 'Enter' para continuar)");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Operación cancelada.");
                                Console.WriteLine("(Presione 'Enter' para continuar)");
                                Console.ReadLine();
                            }
                        }
                        else if (deleteChoice == 0)
                        {
                            // Cancelar operación de borrado
                            Console.WriteLine("Operación cancelada.");
                            Console.WriteLine("(Presione 'Enter' para continuar)");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Opción inválida.");
                            Console.WriteLine("(Presione 'Enter' para continuar)");
                            Console.ReadLine();
                        }
                    }
                }

                else if (option == 5)
                {
                    break;
                }

                Console.WriteLine("=====================================================================================================");
            }
        }
    }
}

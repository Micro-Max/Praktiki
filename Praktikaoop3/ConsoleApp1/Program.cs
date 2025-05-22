namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System.Text;

    public class Hospital
    {
        private static int hospitalCount = 0;
        private const int MAX_DEPARTMENTS = 10;

        private int hospitalId;
        private string name;
        private string address;
        private List<Department> departments;

        public int HospitalId
        {
            get { return hospitalId; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public List<Department> Departments
        {
            get { return departments; }
            set { departments = value; }
        }

        public static int GetTotalHospitals()
        {
            return hospitalCount;
        }

        public Hospital(int hospitalId)
        {
            this.hospitalId = hospitalId;
            this.departments = new List<Department>();
            hospitalCount++;
        }

        public Hospital(int hospitalId, string name) : this(hospitalId)
        {
            this.name = name;
        }

        public Hospital(int hospitalId, string name, string address) : this(hospitalId, name)
        {
            this.address = address;
        }

        public Hospital(int hospitalId, string name, string address, List<Department> departments) : this(hospitalId, name, address)
        {
            this.departments = departments;
        }

        public void AddDepartment(Department department)
        {
            if (departments.Count >= MAX_DEPARTMENTS)
            {
                Console.WriteLine($"Невозможно добавить отделение. Достигнуто максимальное количество отделений ({MAX_DEPARTMENTS}).");
                return;
            }
            departments.Add(department);
        }

        public bool RemoveDepartment(int departmentId)
        {
            Department department = departments.FirstOrDefault(d => d.DepartmentId == departmentId);
            if (department != null)
            {
                departments.Remove(department);
                return true;
            }
            return false;
        }

        public void SaveToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"ID Поликлиники: {hospitalId}");
                writer.WriteLine($"Имя: {name}");
                writer.WriteLine($"Адрес: {address}");
                writer.WriteLine($"Счётчик отдела: {departments.Count}");

                foreach (var department in departments)
                {
                    writer.WriteLine($"\nОтделы: {department.GetInfo()}");

                    writer.WriteLine("\nДоктора:");
                    foreach (var doctor in department.Doctors)
                    {
                        writer.WriteLine($"- {doctor.FirstName.Capitalize()} {doctor.LastName.Capitalize()}, ID: {doctor.DoctorId}, Спецальность: {doctor.Specialization}");
                    }
                }
            }
        }

        public static Hospital LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
                return null;

            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length < 4)
                return null;

            int hospitalId = int.Parse(lines[0].Split(':')[1].Trim());
            string name = lines[1].Split(':')[1].Trim();
            string address = lines[2].Split(':')[1].Trim();

            Hospital hospital = new Hospital(hospitalId, name, address);

            return hospital;
        }
    }

    public abstract class Department
    {
        private int departmentId;
        private string name;
        private Doctor headOfDepartment;
        private List<Doctor> doctors;
        private bool[] beds;

        public int DepartmentId
        {
            get { return departmentId; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Doctor HeadOfDepartment
        {
            get { return headOfDepartment; }
            set { headOfDepartment = value; }
        }

        public List<Doctor> Doctors
        {
            get { return doctors; }
            set { doctors = value; }
        }

        public bool[] Beds
        {
            get { return beds; }
            set { beds = value; }
        }

        public Department()
        {
            this.doctors = new List<Doctor>();
        }

        public Department(int departmentId, string name, Doctor headOfDepartment, List<Doctor> doctors, bool[] beds)
        {
            this.departmentId = departmentId;
            this.name = name;
            this.headOfDepartment = headOfDepartment;
            this.doctors = doctors;
            this.beds = beds;
        }

        public void AddDoctor(Doctor doctor)
        {
            doctors.Add(doctor);
        }

        public bool RemoveDoctor(int doctorId)
        {
            Doctor doctor = FindDoctor(doctorId);
            if (doctor != null)
            {
                doctors.Remove(doctor);
                return true;
            }
            return false;
        }

        public Doctor FindDoctor(int doctorId)
        {
            return doctors.FirstOrDefault(d => d.DoctorId == doctorId);
        }

        public int GetAvailableBeds()
        {
            if (beds == null) return 0;
            return beds.Count(bed => bed == true);
        }

        protected void NotifyDoctors(string message)
        {
            foreach (var doctor in Doctors)
            {
                Console.WriteLine($"Уведомление для доктора {doctor.FirstName.Capitalize()} {doctor.LastName.Capitalize()}: {message}");
            }
        }

        public abstract void NotifyAboutEmergency(string message);

        public abstract void NotifyAboutScheduleChange(string message);

        public abstract void SpecificDepartmentFunctionality();

        public abstract string GetPatientTreatmentRecommendations(Patient patient);

        public string GetInfo()
        {
            return $"ID: {departmentId}, Имя: {name}, Доктора: {doctors.Count}, Свободные койки: {GetAvailableBeds()}";
        }
    }

    public class Cardiology : Department
    {
        public Cardiology() : base()
        {
        }

        public Cardiology(int departmentId, string name, Doctor headOfDepartment, List<Doctor> doctors, bool[] beds)
            : base(departmentId, name, headOfDepartment, doctors, beds)
        {
        }

        public override void NotifyAboutEmergency(string message)
        {
            NotifyDoctors($"ЭКСТРЕННОЕ СООБЩЕНИЕ КАРДИОЛОГИЯ: {message}");
        }

        public override void NotifyAboutScheduleChange(string message)
        {
            NotifyDoctors($"Изменение расписания в Кардиологии: {message}");
        }

        public override void SpecificDepartmentFunctionality()
        {
            Console.WriteLine("Выполняется специфическая функциональность отделения Кардиологии: профилактика сердечно-сосудистых заболеваний.");
        }

        public override string GetPatientTreatmentRecommendations(Patient patient)
        {
            return $"Кардиологические рекомендации для пациента {patient.FirstName.Capitalize()} {patient.LastName.Capitalize()}: контроль давления, здоровое питание, регулярные физические нагрузки.";
        }
    }

    public class Surgery : Department
    {
        public Surgery() : base()
        {
        }

        public Surgery(int departmentId, string name, Doctor headOfDepartment, List<Doctor> doctors, bool[] beds)
            : base(departmentId, name, headOfDepartment, doctors, beds)
        {
        }

        public override void NotifyAboutEmergency(string message)
        {
            NotifyDoctors($"ЭКСТРЕННОЕ СООБЩЕНИЕ ХИРУРГИЯ: {message}");
        }

        public override void NotifyAboutScheduleChange(string message)
        {
            NotifyDoctors($"Изменение расписания в Хирургии: {message}");
        }

        public override void SpecificDepartmentFunctionality()
        {
            Console.WriteLine("Выполняется специфическая функциональность отделения Хирургии: планирование хирургических вмешательств.");
        }

        public override string GetPatientTreatmentRecommendations(Patient patient)
        {
            return $"Хирургические рекомендации для пациента {patient.FirstName.Capitalize()} {patient.LastName.Capitalize()}: соблюдение постельного режима, обработка ран, прием антибиотиков.";
        }
    }

    public class Therapeutic : Department
    {
        public Therapeutic() : base()
        {
        }

        public Therapeutic(int departmentId, string name, Doctor headOfDepartment, List<Doctor> doctors, bool[] beds)
            : base(departmentId, name, headOfDepartment, doctors, beds)
        {
        }

        public override void NotifyAboutEmergency(string message)
        {
            NotifyDoctors($"ЭКСТРЕННОЕ СООБЩЕНИЕ ТЕРАПИЯ: {message}");
        }

        public override void NotifyAboutScheduleChange(string message)
        {
            NotifyDoctors($"Изменение расписания в Терапии: {message}");
        }

        public override void SpecificDepartmentFunctionality()
        {
            Console.WriteLine("Выполняется специфическая функциональность отделения Терапии: консультация по общим заболеваниям.");
        }

        public override string GetPatientTreatmentRecommendations(Patient patient)
        {
            return $"Терапевтические рекомендации для пациента {patient.FirstName.Capitalize()} {patient.LastName.Capitalize()}: прием лекарств согласно назначению, регулярные осмотры, соблюдение режима.";
        }
    }

    public class Doctor
    {
        private int doctorId;
        private string firstName;
        private string lastName;
        private string specialization;
        private List<Patient> patients;

        public int DoctorId
        {
            get { return doctorId; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Specialization
        {
            get { return specialization; }
            set
            {
                if (value == "Cardiology" || value == "Surgery" || value == "Therapeutic")
                {
                    specialization = value;
                }
                else
                {
                    throw new ArgumentException("Invalid specialization");
                }
            }
        }

        public List<Patient> Patients
        {
            get { return patients; }
            set { patients = value; }
        }

        public Doctor()
        {
            this.patients = new List<Patient>();
        }

        public Doctor(int doctorId, string firstName, string lastName, string specialization) : this()
        {
            this.doctorId = doctorId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.Specialization = specialization;
        }

        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
        }

        public void AddPatient(int patientId, string firstName, string lastName, DateTime dateOfBirth, string diagnosis)
        {
            Patient patient = new Patient(patientId, firstName, lastName, dateOfBirth, diagnosis);
            patients.Add(patient);
        }

        public bool RemovePatient(int patientId)
        {
            Patient patient = FindPatient(patientId);
            if (patient != null)
            {
                patients.Remove(patient);
                return true;
            }
            return false;
        }

        public Patient FindPatient(int patientId)
        {
            return patients.FirstOrDefault(p => p.PatientId == patientId);
        }

        public int GetPatientCount()
        {
            return patients.Count;
        }

        public void SaveToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"ID Доктора: {doctorId}");
                writer.WriteLine($"Имя и Фамилия: {firstName.Capitalize()} {lastName.Capitalize()}");
                writer.WriteLine($"Специализация: {specialization}");
                writer.WriteLine($"Счётчик пациентов: {patients.Count}");

                writer.WriteLine("\nПациенты:");
                foreach (var patient in patients)
                {
                    writer.WriteLine($"- {patient.ToString()}");
                }
            }
        }

        public static Doctor LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
                return null;

            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length < 4)
                return null;

            int doctorId = int.Parse(lines[0].Split(':')[1].Trim());
            string[] nameparts = lines[1].Split(':')[1].Trim().Split(' ');
            string firstName = nameparts[0];
            string lastName = nameparts[1];
            string specialization = lines[2].Split(':')[1].Trim();

            return new Doctor(doctorId, firstName, lastName, specialization);
        }

        public virtual string GetPatientTreatmentRecommendations(Patient patient)
        {
            return $"Общие рекомендации для пациента {patient.FirstName.Capitalize()} {patient.LastName.Capitalize()} от доктора {firstName.Capitalize()} {lastName.Capitalize()}.";
        }
    }

    public class Patient
    {
        private int patientId;
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private string diagnosis;

        public int PatientId
        {
            get { return patientId; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public string Diagnosis
        {
            get { return diagnosis; }
            set { diagnosis = value; }
        }

        public Patient(int patientId)
        {
            this.patientId = patientId;
        }

        public Patient(int patientId, string firstName, string lastName) : this(patientId)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Patient(int patientId, string firstName, string lastName, DateTime dateOfBirth) : this(patientId, firstName, lastName)
        {
            this.dateOfBirth = dateOfBirth;
        }

        public Patient(int patientId, string firstName, string lastName, DateTime dateOfBirth, string diagnosis)
            : this(patientId, firstName, lastName, dateOfBirth)
        {
            this.diagnosis = diagnosis;
        }

        public void UpdateDiagnosis(string newDiagnosis)
        {
            diagnosis = newDiagnosis;
        }

        public int GetAge()
        {
            return DateTime.Now.Year - dateOfBirth.Year -
                (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear ? 1 : 0);
        }

        public override string ToString()
        {
            return $"ID пациента: {patientId}, Имя и Фамилия: {firstName.Capitalize()} {lastName.Capitalize()}, Дата рождения: {dateOfBirth.ToShortDateString()}, Диагноз: {diagnosis}";
        }

        public void SaveToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"ID Пациента: {patientId}");
                writer.WriteLine($"Имя и Фамилия: {firstName.Capitalize()} {lastName.Capitalize()}");
                writer.WriteLine($"Дата рождения: {dateOfBirth.ToShortDateString()}");
                writer.WriteLine($"Возраст: {GetAge()}");
                writer.WriteLine($"Диагноз: {diagnosis}");
            }
        }

        public static Patient LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
                return null;

            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length < 5)
                return null;

            int patientId = int.Parse(lines[0].Split(':')[1].Trim());
            string[] nameparts = lines[1].Split(':')[1].Trim().Split(' ');
            string firstName = nameparts[0];
            string lastName = nameparts[1];
            DateTime dateOfBirth = DateTime.Parse(lines[2].Split(':')[1].Trim());
            string diagnosis = lines[4].Split(':')[1].Trim();

            return new Patient(patientId, firstName, lastName, dateOfBirth, diagnosis);
        }
    }

    public static class StringExtensions
    {
        public static string Capitalize(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return string.Empty;

            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrEmpty(words[i]))
                {
                    char[] letters = words[i].ToCharArray();
                    letters[0] = char.ToUpper(letters[0]);
                    words[i] = new string(letters);
                }
            }
            return string.Join(" ", words);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Количество созданных больниц: {Hospital.GetTotalHospitals()}");

            Hospital hosp = new Hospital(1, "Центральная Городская Поликлиника", "ул. Пушкина, 1");
            Console.WriteLine($"Количество созданных больниц: {Hospital.GetTotalHospitals()}");

            Doctor doc1 = new Doctor(1, "Владимир", "Демаков", "Cardiology");
            Doctor doc2 = new Doctor(2, "Владимир", "Зоркин", "Surgery");

            Patient pat1 = new Patient(1, "Константин", "Осипов", new DateTime(2007, 10, 25), "Гипертония");
            Patient pat2 = new Patient(2, "Александр", "Панин", new DateTime(2007, 11, 15), "Аритмия");

            doc1.AddPatient(pat1);
            doc1.AddPatient(pat2);

            Cardiology cardio = new Cardiology(1, "Кардиология", doc1, new List<Doctor> { doc1 }, new bool[] { true, false, true, true });

            Surgery sur = new Surgery(2, "Хирургия", doc2, new List<Doctor> { doc2 }, new bool[] { true, true, false });

            hosp.AddDepartment(cardio);
            hosp.AddDepartment(sur);

            Console.WriteLine($"Больница: {hosp.Name}");
            Console.WriteLine($"Доступных коек в отделении Кардиологии: {cardio.GetAvailableBeds()}");
            Console.WriteLine($"Врач {doc1.FirstName.Capitalize()} {doc1.LastName.Capitalize()} наблюдает {doc1.GetPatientCount()} пациентов");

            pat1.UpdateDiagnosis("Тяжелая Гипертония");
            Console.WriteLine(pat1.ToString());

            cardio.NotifyAboutEmergency("Требуется срочная помощь в палате 215!");
            sur.NotifyAboutScheduleChange("Операции перенесены с 10:00 на 09:00");

            Console.WriteLine();
            Console.WriteLine("Информация об отделении: " + cardio.GetInfo());

            Console.WriteLine();
            cardio.SpecificDepartmentFunctionality();
            sur.SpecificDepartmentFunctionality();

            Console.WriteLine();
            Console.WriteLine(cardio.GetPatientTreatmentRecommendations(pat1));
            Console.WriteLine(sur.GetPatientTreatmentRecommendations(pat2));

            Console.WriteLine();
            Console.WriteLine("Тестирование сохранения и загрузки данных:");
            hosp.SaveToFile("hospital.txt");
            doc1.SaveToFile("doctor.txt");
            pat1.SaveToFile("patient.txt");
            Console.WriteLine("Данные сохранены в файлы hospital.txt, doctor.txt, patient.txt");

        }
    }
}

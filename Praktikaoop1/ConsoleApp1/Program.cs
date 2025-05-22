using System;
using System.Collections.Generic;
using System.Linq;

public class Hospital
{
    private int hospitalId;
    private string name;
    private string address;
    private List<Cardiology> departments;

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

    public List<Cardiology> Departments
    {
        get { return departments; }
        set { departments = value; }
    }

    public Hospital(int hospitalId)
    {
        this.hospitalId = hospitalId;
        this.departments = new List<Cardiology>();
    }

    public Hospital(int hospitalId, string name) : this(hospitalId)
    {
        this.name = name;
    }

    public Hospital(int hospitalId, string name, string address) : this(hospitalId, name)
    {
        this.address = address;
    }

    public Hospital(int hospitalId, string name, string address, List<Cardiology> departments) : this(hospitalId, name, address)
    {
        this.departments = departments;
    }
}

public class Cardiology
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

    public Cardiology()
    {
        this.doctors = new List<Doctor>();
    }

    public Cardiology(int departmentId, string name, Doctor headOfDepartment, List<Doctor> doctors, bool[] beds)
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
}

public class Surgery : Cardiology
{
    public Surgery() : base()
    {
    }

    public Surgery(int departmentId, string name, Doctor headOfDepartment, List<Doctor> doctors, bool[] beds)
        : base(departmentId, name, headOfDepartment, doctors, beds)
    {
    }
}

public class Therapeutic : Cardiology
{
    public Therapeutic() : base()
    {
    }

    public Therapeutic(int departmentId, string name, Doctor headOfDepartment, List<Doctor> doctors, bool[] beds)
        : base(departmentId, name, headOfDepartment, doctors, beds)
    {
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
        return $"ID пациента: {patientId}, Имя: {firstName} {lastName}, Дата рождения: {dateOfBirth.ToShortDateString()}, Диагноз: {diagnosis}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Hospital hosp = new Hospital(1, "Центральная Городская Поликлиника", "ул. Пушкина, 1");

        Doctor doc1 = new Doctor(1, "Владимир", "Демаков", "Cardiology");
        Doctor doc2 = new Doctor(2, "Владимир", "Зоркин", "Surgery");

        Patient pat1 = new Patient(1, "Константин", "Осипов", new DateTime(2007, 10, 25), "Гипертония");
        Patient pat2 = new Patient(2, "Александр", "Панин", new DateTime(2007, 11, 15), "Аритмия");

        doc1.AddPatient(pat1);
        doc1.AddPatient(pat2);

        Cardiology cardio = new Cardiology(1, "Кардиология", doc1, new List<Doctor> { doc1 }, new bool[] { true, false, true, true });

        Surgery sur = new Surgery(2, "Хирургия", doc2, new List<Doctor> { doc2 }, new bool[] { true, true, false });

        hosp.Departments.Add(cardio);
        hosp.Departments.Add(sur);

        Console.WriteLine($"Госпиталь: {hosp.Name}");
        Console.WriteLine($"Доступных коек в отделении Кардиологии: {cardio.GetAvailableBeds()}");
        Console.WriteLine($"Врач {doc1.FirstName} {doc1.LastName} наблюдает {doc1.GetPatientCount()} пациентов");

        pat1.UpdateDiagnosis("Тяжелая Гипертония");
        Console.WriteLine(pat1.ToString());
    }
}
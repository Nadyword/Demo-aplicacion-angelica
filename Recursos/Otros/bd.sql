-- Crear tabla de clientes
CREATE TABLE clientes (
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  nombre TEXT NOT NULL,
  apellido TEXT NOT NULL,
  cedula TEXT NOT NULL UNIQUE,
  telefono TEXT,
  sexo INTEGER,
  direccion TEXT,
  ocupacion TEXT
);

-- Crear tabla de antecedentes personales
CREATE TABLE antecedentes_personales (
  cliente_id INTEGER PRIMARY KEY,
  enfermedad_cronica TEXT,
  alergia_medicamentos TEXT,
  alergia_alimentos TEXT,
  cirugias TEXT,
  tratamientos_esteticos TEXT,
  biopolimeros TEXT,
  FOREIGN KEY (cliente_id) REFERENCES clientes (id) ON DELETE CASCADE
);

-- Crear tabla de hábitos psicobiológicos
CREATE TABLE habitos_psicobio (
  cliente_id INTEGER PRIMARY KEY,
  tabaquismo TEXT,
  actividad_fisica TEXT,
  alcohol TEXT,
  estres TEXT,
  FOREIGN KEY (cliente_id) REFERENCES clientes (id) ON DELETE CASCADE
);

-- Crear tabla de examen físico
CREATE TABLE examen_fisico (
  cliente_id INTEGER PRIMARY KEY,
  descripcion TEXT,
  FOREIGN KEY (cliente_id) REFERENCES clientes (id) ON DELETE CASCADE
);

-- Crear tabla de tratamientos
CREATE TABLE "tratamientos" (
  cliente_id	INTEGER,
  id_trata	INTEGER,
  descripcion	TEXT,
  fecha"	TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  FOREIGN KEY("cliente_id") REFERENCES "clientes"("id") ON DELETE CASCADE
);

-- Crear tabla de tratamientos (combo)
CREATE TABLE tratamientos_combo (
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  descripcion TEXT,
  orden INTEGER DEFAULT 0,
  activo INTEGER DEFAULT 1
);

-- Crear tabla de historial de tratamiento
CREATE TABLE historial_tratamiento (
  cliente_id INTEGER PRIMARY KEY,
  descripcion TEXT
  FOREIGN KEY (cliente_id) REFERENCES clientes (id) ON DELETE CASCADE
);

-- Insertar registros de ejemplo en la tabla tratamientos
INSERT INTO tratamientos_combo (descripcion, orden, activo) VALUES
('Terapia física para rehabilitación de rodilla', 1, 1),
('Sesión de acupuntura', 2, 1),
('Tratamiento para hipertensión', 1, 1),
('Revisión médica general', 2, 0),
('Control de peso y nutrición', 1, 1),
('Terapia psicológica', 2, 0),
('Consulta dermatológica', 1, 1),
('Tratamiento para alergias', 2, 1);

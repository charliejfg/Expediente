-- SCHEMA: hja

-- DROP SCHEMA hja ;

CREATE SCHEMA hja
    AUTHORIZATION hja;


-- Table: hja.rol

-- DROP TABLE hja.rol;

CREATE TABLE hja.rol
(
    id bigint NOT NULL,
    rol_nombre character varying COLLATE pg_catalog."default",
    CONSTRAINT rol_pkey PRIMARY KEY (id)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE hja.rol
    OWNER to hja;

-- Table: hja.persona

-- DROP TABLE hja.persona;

CREATE TABLE hja.persona
(
    id bigint NOT NULL,
    nombre character varying COLLATE pg_catalog."default",
    apellido_uno character varying COLLATE pg_catalog."default",
    apellido_dos character varying COLLATE pg_catalog."default",
    cedula character varying COLLATE pg_catalog."default",
    telefono character varying COLLATE pg_catalog."default",
    correo character varying COLLATE pg_catalog."default",
    clave character varying COLLATE pg_catalog."default",
    entrada boolean,
    CONSTRAINT "PK_persona" PRIMARY KEY (id)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE hja.persona
    OWNER to hja;

-- Table: hja.persona_rol

-- DROP TABLE hja.persona_rol;

-- Table: hja.persona_rol

-- DROP TABLE hja.persona_rol;

CREATE TABLE hja.persona_rol
(
    id bigint NOT NULL,
    persona_id bigint NOT NULL,
    rol_id bigint NOT NULL,
    CONSTRAINT persona_rol_pkey PRIMARY KEY (id),
    CONSTRAINT persona_rol_persona__fk FOREIGN KEY (persona_id)
        REFERENCES hja.persona (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT persona_rol_rol_id_fk FOREIGN KEY (rol_id)
        REFERENCES hja.rol (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE hja.persona_rol
    OWNER to hja;

CREATE SEQUENCE rol_seq
  MAXVALUE 100000000000;

CREATE SEQUENCE persona_seq
  MAXVALUE 100000000000;


INSERT INTO rol values (nextval('rol_seq') , 'PACIENTE');
INSERT INTO rol values (nextval('rol_seq') , 'ADMIN');





----------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------
--------------------------------NO EJECUTADO AUN----------------------------------------------------
----------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------












CREATE TABLE hjaschema.kardex
(
  id bigint NOT NULL,
  encargado_id bigint,
  pam_id bigint not null,--Persona adulta mayor
  fecha_empezar timestamp,
  CONSTRAINT kardex_pk PRIMARY KEY (id),
  CONSTRAINT kardex_encargado_fkey FOREIGN KEY (encargado_id)
        REFERENCES  hjaschema.persona (id) MATCH SIMPLE
        ON UPDATE CASCADE
        ON DELETE CASCADE,
   CONSTRAINT kardex_pam_fkey FOREIGN KEY (pam_id)
        REFERENCES hjaschema.persona (id) MATCH SIMPLE
        ON UPDATE CASCADE
        ON DELETE CASCADE
)
WITH (
  OIDS=FALSE
);
ALTER TABLE hjaschema.kardex
  OWNER TO hja;
GRANT ALL ON TABLE hjaschema.kardex TO hja;

CREATE SEQUENCE hjaschema.kardex_seq
    INCREMENT 1
    START 8
    MINVALUE 1
    MAXVALUE 9223372036854775807
    CACHE 1;

ALTER SEQUENCE hjaschema.kardex_seq
    OWNER TO hja;






CREATE TABLE hjaschema.kardex_detalle
(
  id bigint NOT NULL,
  kardex_id bigint NOT NULL,
  fecha_empezar timestamp,
  medicamento_id bigint NOT NULL,
  cantidad numeric, 
  dosis character varying.
  via_id bigint not null,
  horario character varying,
  CONSTRAINT kardex_detalle_pk PRIMARY KEY (id),
  CONSTRAINT kardex_detalle_kardex_fkey FOREIGN KEY (kardex_id)
        REFERENCES  hjaschema.kardex (id) MATCH SIMPLE
        ON UPDATE CASCADE
        ON DELETE CASCADE,
   CONSTRAINT kardex_detalle_medicamente_fkey FOREIGN KEY (medicamento_id)
        REFERENCES hjaschema.medicamento (id) MATCH SIMPLE
        ON UPDATE CASCADE
        ON DELETE CASCADE,
    CONSTRAINT kardex_detalle_via_fkey FOREIGN KEY (via_id)
        REFERENCES hjaschema.via (id) MATCH SIMPLE
        ON UPDATE CASCADE
        ON DELETE CASCADE,
)
WITH (
  OIDS=FALSE
);
ALTER TABLE hjaschema.kardex_detalle
  OWNER TO hja;
GRANT ALL ON TABLE hjaschema.kardex_detalle TO hja;

CREATE SEQUENCE hjaschema.kardex_detalle_seq
    INCREMENT 1
    START 8
    MINVALUE 1
    MAXVALUE 9223372036854775807
    CACHE 1;

ALTER SEQUENCE hjaschema.kardex_detalle_seq
    OWNER TO hja;



CREATE TABLE hjaschema.medicamento
(
  id bigint NOT NULL,
  descripcion character varying,
  codigo character varying,
  clave character varying,
  usuario character varying,
  CONSTRAINT medicamento_pk PRIMARY KEY (id),
)
WITH (
  OIDS=FALSE
);
ALTER TABLE hjaschema.medicamento
  OWNER TO hja;
GRANT ALL ON TABLE hjaschema.medicamento TO hja;

CREATE SEQUENCE hjaschema.medicamento_seq
    INCREMENT 1
    START 8
    MINVALUE 1
    MAXVALUE 9223372036854775807
    CACHE 1;

ALTER SEQUENCE hjaschema.medicamento_seq
    OWNER TO hja;







CREATE TABLE hjaschema.receta
(
  id bigint NOT NULL,
  encargado_id bigint NOT Null,
  pam_id bigint NOT NULL,
  fecha timestamp
  CONSTRAINT receta_pk PRIMARY KEY (id),
  CONSTRAINT receta_encargado_fkey FOREIGN KEY (encargado_id)
        REFERENCES  hjaschema.persona (id) MATCH SIMPLE
        ON UPDATE CASCADE
        ON DELETE CASCADE,
  CONSTRAINT receta_pam_fkey FOREIGN KEY (encargado_id)
        REFERENCES  hjaschema.persona (id) MATCH SIMPLE
        ON UPDATE CASCADE
        ON DELETE CASCADE,
)
WITH (
  OIDS=FALSE
);
ALTER TABLE hjaschema.receta
  OWNER TO hja;
GRANT ALL ON TABLE hjaschema.receta TO hja;

CREATE SEQUENCE hjaschema.receta_seq
    INCREMENT 1
    START 8
    MINVALUE 1
    MAXVALUE 9223372036854775807
    CACHE 1;

ALTER SEQUENCE hjaschema.receta_seq
    OWNER TO hja;


CREATE TABLE hjaschema.receta_detalle
(
  id bigint NOT NULL,
  receta_id bigint NOT Null,
  medicamento_id bigint NOT NULL,
  via_id bigint NOT NULL, 
  frecuencia character varying,
  fecha timestamp,
  CONSTRAINT receta_detalle_pk PRIMARY KEY (id),
  CONSTRAINT receta_detalle_receta_id_fkey FOREIGN KEY (receta_id)
        REFERENCES  hjaschema.receta (id) MATCH SIMPLE
        ON UPDATE CASCADE
        ON DELETE CASCADE,
  CONSTRAINT receta_detalle_medicamento_fkey FOREIGN KEY (medicamento_id)
        REFERENCES  hjaschema.medicamento (id) MATCH SIMPLE
        ON UPDATE CASCADE
        ON DELETE CASCADE,
  CONSTRAINT receta_detalle_via_fkey FOREIGN KEY (via_id)
        REFERENCES  hjaschema.via (id) MATCH SIMPLE
        ON UPDATE CASCADE
        ON DELETE CASCADE,
)
WITH (
  OIDS=FALSE
);
ALTER TABLE hjaschema.receta_detalle
  OWNER TO hja;
GRANT ALL ON TABLE hjaschema.receta_detalle TO hja;

CREATE SEQUENCE hjaschema.receta_detalle_seq
    INCREMENT 1
    START 8
    MINVALUE 1
    MAXVALUE 9223372036854775807
    CACHE 1;

ALTER SEQUENCE hjaschema.receta_detalle_seq
    OWNER TO hja;



CREATE TABLE hjaschema.rol
(
  id bigint NOT NULL,
  descripcion character varying,
  CONSTRAINT rol_pk PRIMARY KEY (id),
)
WITH (
  OIDS=FALSE
);
ALTER TABLE hjaschema.rol
  OWNER TO hja;
GRANT ALL ON TABLE hjaschema.rol TO hja;

CREATE SEQUENCE hjaschema.rol_seq
    INCREMENT 1
    START 8
    MINVALUE 1
    MAXVALUE 9223372036854775807
    CACHE 1;

ALTER SEQUENCE hjaschema.rol_seq
    OWNER TO hja;

CREATE TABLE hjaschema.via
(
  id bigint NOT NULL,
  descripcion character varying,
  CONSTRAINT via_pk PRIMARY KEY (id),
)
WITH (
  OIDS=FALSE
);
ALTER TABLE hjaschema.via
  OWNER TO hja;
GRANT ALL ON TABLE hjaschema.via TO hja;

CREATE SEQUENCE hjaschema.via_seq
    INCREMENT 1
    START 8
    MINVALUE 1
    MAXVALUE 9223372036854775807
    CACHE 1;

ALTER SEQUENCE hjaschema.via_seq
    OWNER TO hja;



--iNSERT DE VIA --
/*
INSERT INTO via VALUES (nextval('via_seq'), 'ORAL' );
INSERT INTO via VALUES (nextval('via_seq'), 'SUBBLINGUAL' );
INSERT INTO via VALUES (nextval('via_seq'), 'TOPICA' );
INSERT INTO via VALUES (nextval('via_seq'), 'TRANSDERMICA' );
INSERT INTO via VALUES (nextval('via_seq'), 'OFTALMICA' );
INSERT INTO via VALUES (nextval('via_seq'), 'OTICA' );
INSERT INTO via VALUES (nextval('via_seq'), 'INTRANASAL' );
INSERT INTO via VALUES (nextval('via_seq'), 'RECTAL' );
INSERT INTO via VALUES (nextval('via_seq'), 'PARENTERAL' );
*/
-- Table: public.acao_tb

-- DROP TABLE IF EXISTS public.acao_tb;

CREATE TABLE IF NOT EXISTS public.acao_tb
(
    id integer NOT NULL DEFAULT nextval('acao_tb_id_seq'::regclass),
    nome text COLLATE pg_catalog."default" NOT NULL,
    ultimo text COLLATE pg_catalog."default",
    maxima text COLLATE pg_catalog."default",
    minima text COLLATE pg_catalog."default",
    variacao text COLLATE pg_catalog."default",
    variacao_porcent text COLLATE pg_catalog."default",
    volume text COLLATE pg_catalog."default",
    data_hora date,
    CONSTRAINT acao_tb_pkey PRIMARY KEY (id)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.acao_tb
    OWNER to postgres;
-- Table: public.moeda_tb

-- DROP TABLE IF EXISTS public.moeda_tb;

CREATE TABLE IF NOT EXISTS public.moeda_tb
(
    id integer NOT NULL DEFAULT nextval('moeda_tb_id_seq'::regclass),
    nome text COLLATE pg_catalog."default" NOT NULL,
    compra text COLLATE pg_catalog."default",
    venda text COLLATE pg_catalog."default",
    maxima text COLLATE pg_catalog."default",
    minima text COLLATE pg_catalog."default",
    variacao text COLLATE pg_catalog."default",
    variacao_porcent text COLLATE pg_catalog."default",
    data_hora date,
    CONSTRAINT moeda_tb_pkey PRIMARY KEY (id)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.moeda_tb
    OWNER to postgres;
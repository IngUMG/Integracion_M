
show create view vista_bitacora;

describe vista_bitacora;
describe bitacora;

select * from bitacora;
select * from vista_bitacora;

create VIEW `vista_bitacora` AS select `u`.`usuario` AS `usuario`,
`b`.`fecha_bitacora` AS `fecha_bitacora`,
`b`.`hora_bitacora` AS `hora_bitacora`,
`b`.`accion_usuario` AS `accion_usuario`,
`ap`.`desc_app` AS `desc_app`,
`b`.`resultado_bitacora` AS `resultado_bitacora`,
`b`.`error_bitacora` AS `error_bitacora`,
`b`.`ip_pc` AS `ip_pc` from
((`usuario` `u` join `bitacora` `b`
on((`b`.`id_usuario` = `u`.`id_usuario`))) 
join `bitacora_app` `ap` 
on((`b`.`id_aplicacion` = `ap`.`id_aplicacion`)))




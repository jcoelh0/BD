
-- 5.3
-- a)
-- π numUtente, nome (σ numPresc=null (π numUtente, nome (paciente) ⟕ prescricao))
select PA.n_utente, PA.nome
from PRESCRIÇAO_MEDICAMENTOS.PACIENTE as PA 
left join PRESCRIÇAO_MEDICAMENTOS.PRESCRIÇAO as PR on PA.n_utente=PR.n_utente
where PR.n_prescricao is null

-- b)
-- π especialidade, num (γ especialidade; count(especialidade) -> num ((prescricao ⨝ numMedico=numSNS medico)))
select especialidade, count(especialidade) as num
from PRESCRIÇAO_MEDICAMENTOS.prescriçao as P join PRESCRIÇAO_MEDICAMENTOS.MEDICO as MD on P.n_medico=MD.n_medico
group by especialidade

-- c)
-- π farmacia, num (γ farmacia; count(numPresc) -> num (σ farmacia != null (prescricao)))
select nome_farmacia, count(n_prescricao) as num
from PRESCRIÇAO_MEDICAMENTOS.prescriçao
where nome_farmacia is not null
group by nome_farmacia

-- d)
-- π farmaco.numRegFarm, nome (σ numPresc=null (σ numRegFarm=906 (farmaco) ⟕ nome=nomeFarmaco presc_farmaco))
select F.n_registo_farm, F.nome_comercial
from PRESCRIÇAO_MEDICAMENTOS.FARMACO as F 
left join PRESCRIÇAO_MEDICAMENTOS.PRESCRIÇAO as P on F.n_registo_farm=P.n_prescricao
where P.n_prescricao is null and F.n_registo_farm=906

-- e)
-- π farmacia, numRegFarm, num (γ farmacia, numRegFarm; count(prescricao.numPresc) -> num (σ farmacia!=null (π prescricao.numPresc, farmacia (prescricao)) ⨝ prescricao.numPresc=presc_farmaco.numPresc (presc_farmaco)))
select P.nome_farmacia, P.n_prescricao, count(P.n_prescricao) as num
from
(
	select n_prescricao, nome_farmacia
	from Prescriçao_medicamentos.prescriçao
	where nome_farmacia is not null
) as P
join PRESCRIÇAO_MEDICAMENTOS.PRESCRIÇAO as PF on P.n_prescricao=PF.n_prescricao 
group by P.nome_farmacia, P.n_prescricao

-- f)
-- π numUtente (σ num>1 (π numUtente,num (γ numUtente; count(numUtente) -> num (π numUtente, numMedico, num (γ numUtente, numMedico; count(numUtente) -> num prescricao)))))
select n_utente
from (
	select n_utente, count(n_utente) as num
	from (
		select n_utente, n_medico, count(n_utente) as num
		from prescriçao_medicamentos.prescriçao
		group by n_utente, n_medico
	) as P
	group by n_utente

) as P
where num > 1
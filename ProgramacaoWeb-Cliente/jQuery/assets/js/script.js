const dataNascimento = document.getElementById("dataNascimentoInput");

// validate Form
const nameInput = document.getElementById("nameInput");
const emailInput = document.getElementById("emailInput");
const mensagemInput = document.getElementById("mensagemInput");
const dataNascimentoInput = document.getElementById("dataNascimentoInput");
const genderSelect = document.querySelectorAll('input[name="gender"]');


const termosEcondicoes = document.getElementById("termosEcondicoes");

const submitForm = document.getElementById("submitForm");


const fillBirthYearSelect = () => {
  for (let i = 1900; i <= 2023; i++) {
    const option = document.createElement("option");
    option.value = i;
    option.text = `Ano ${i}`;
    dataNascimento.appendChild(option);
  }
}
document.addEventListener('DOMContentLoaded', () => fillBirthYearSelect())


const isGenderSelected = () => {
  const verifySelected = Array.from(genderSelect).some((_gen) => _gen.checked);
  return verifySelected;
}


// validate Form
const validateForm = () => {
  if (!nameInput.value || !emailInput.value || !dataNascimentoInput.value)
    return false;

  if (!isGenderSelected())
    return false;

  if (!termosEcondicoes.checked)
    return false;

  return true;
}

submitForm.addEventListener("click", (event) => {
  event.preventDefault();

  if (validateForm()) {
    alert("Formulário enviado com sucesso!");
  }
  else
    alert("Preencha todos os campos!");
});

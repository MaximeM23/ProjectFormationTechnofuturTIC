import { FormGroup, ValidationErrors, ValidatorFn } from '@angular/forms';

export const PasswordValidatorMaxLength: ValidatorFn = (control: FormGroup): ValidationErrors | null => {
  if(control.value.length == 0) return { 'maxLength' : false}
  return  control.dirty && control.value.length > 50 ? { 'maxLength' : true} : null 
};

export const PasswordValidatorMinLength: ValidatorFn = (control: FormGroup): ValidationErrors => {
  if(control.value.length == 0) return { 'minLength' : false}
  return  control.dirty && control.value.length < 3 ? { 'minLength' : true} : null 
};

export const PasswordUpdateValidatorMinLength: ValidatorFn = (control: FormGroup): ValidationErrors => {
  if(control.value.length == 0) return { 'minLength' : false}
  return  control.dirty && control.value.length < 3 && control.value.length != 0 ? { 'minLength' : true} : null 
};

export const PasswordUpdateValidatorMaxLength: ValidatorFn = (control: FormGroup): ValidationErrors | null => {
  if(control.value.length == 0) return { 'maxLength' : false}
  return  control.dirty && control.value.length > 50 && control.value.length != 0 ? { 'maxLength' : true} : null 
};


